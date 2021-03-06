﻿using Prism.Ioc;
using Prism.Modularity;
using ProductModul.ViewModels;
using ProductModul.Views;
using RevaluationGoodModul.Views;
using DialogWindow = ModelModul.MVVM.DialogWindow;

namespace RevaluationGoodModul
{
    public class RevaluationGoodModul : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<RevaluationGood>();
            containerRegistry.RegisterDialogWindow<DialogWindow>();
            containerRegistry.RegisterDialog<Catalog, СatalogViewModel>();
        }
    }
}
