﻿using Prism.Ioc;
using Prism.Modularity;
using RevaluationProductsModul.Views;

namespace RevaluationProductsModul
{
    public class RevaluationProductsModul : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<RevaluationProductsView>();
        }
    }
}
