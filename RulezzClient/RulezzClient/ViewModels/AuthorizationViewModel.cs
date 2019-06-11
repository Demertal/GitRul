﻿using System;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using ModelModul;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prism.Commands;
using Prism.Regions;

namespace RulezzClient.ViewModels
{
    class AuthorizationViewModel : ViewModelBase
    {
        #region Properties

        private string _login;

        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public DelegateCommand EnterCommand { get; }

        public delegate void LoginEvent(bool completed);
        public event LoginEvent LoginCompleted;

        #endregion

        public AuthorizationViewModel()
        {
            EnterCommand = new DelegateCommand(Enter);
        }

        private void Enter()
        {
            try
            {
                Configuration config = ConfigurationManager.
                    OpenExeConfiguration("RulezzClient.exe");

                ConnectionStringsSection section =
                    config.GetSection("connectionStrings")
                        as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                }

                string dataSource;
                using (StreamReader r = new StreamReader("appsettings.json"))
                {
                    var json = r.ReadToEnd();
                    var data = (JObject)JsonConvert.DeserializeObject(json);
                    var сonnectionStrings = data["ConnectionStrings"].Value<JObject>();
                    dataSource = сonnectionStrings["Server"].Value<string>();
                }

                SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder
                {
                    DataSource = dataSource,
                    InitialCatalog = "AutomationAccountingGoods",
                    UserID = Login,
                    Password = Password,
                    ApplicationName = "EntityFramework"
                };
                EntityConnectionStringBuilder connectionString = new EntityConnectionStringBuilder
                {
                    Metadata =
                        "res://*/AutomationAccountingGoodsModel.csdl|res://*/AutomationAccountingGoodsModel.ssdl|res://*/AutomationAccountingGoodsModel.msl",
                    Provider = "System.Data.SqlClient",
                    ProviderConnectionString = sqlConnection.ConnectionString
                };
                section.ConnectionStrings["AutomationAccountingGoodsEntities"].ConnectionString = connectionString.ConnectionString;
                config.Save();
                AutomationAccountingGoodsEntities.GetInstance(connectionString.ConnectionString);
                AutomationAccountingGoodsEntities.GetInstance().Database.Connection.ConnectionString = sqlConnection.ConnectionString;
                AutomationAccountingGoodsEntities.GetInstance().Database.Connection.Open();
                LoginCompleted?.Invoke(true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}