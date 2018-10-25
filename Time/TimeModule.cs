using Time.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace Time
{
    public class TimeModule : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer _container;

        public TimeModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<ViewA>();
            _regionManager.RequestNavigate("TimeView", nameof(ViewA));
        }
    }
}