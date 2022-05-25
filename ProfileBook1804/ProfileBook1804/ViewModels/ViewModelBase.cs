using Prism.Mvvm;
using Prism.Navigation;


namespace ProfileBook1804.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

       // public ILocalizationService Resource
        //{
          //  get; private set;
        //}

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
            //Resource = localizationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
