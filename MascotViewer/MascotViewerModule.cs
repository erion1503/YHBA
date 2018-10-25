using MascotViewer.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace MascotViewer
{
    public class MascotViewerModule : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer _container;

        public MascotViewerModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<ViewA>();
            _regionManager.RequestNavigate("MascotView", nameof(ViewA));
        }
    }
}