using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using Prism.Navigation;
using Prism.Ioc;
using Prism;
using ProfileBook1804.Views;
using ProfileBook1804.Services.Settings;
using ProfileBook1804.Services.Managers;
using ProfileBook1804.ViewModels;

namespace ProfileBook1804
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync($"{nameof(ProfileBook1804.Views.MainListView)}");
        }
  
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<ISettingsManager>(Container.Resolve<SettingsManager>());
            containerRegistry.RegisterInstance<IProfileManager>(Container.Resolve<ProfileManager>());

            containerRegistry.RegisterForNavigation<NavigationPage>();

           
            containerRegistry.RegisterForNavigation<SingInView, SingInViewModel>();
            containerRegistry.RegisterForNavigation<SingUpView, SingUpViewModel>();
            containerRegistry.RegisterForNavigation<AddContactView, AddContactViewModel>();
            containerRegistry.RegisterForNavigation<MainListView, MainListViewModel>();

        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }


    }
}
