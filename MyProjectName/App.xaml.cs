using BlazorMobile.Common;
using BlazorMobile.Components;
using MyProjectName.Helpers;
using BlazorMobile.Services;

namespace MyProjectName
{
	public partial class App : BlazorApplication
    {
        public App()
        {
            InitializeComponent();

            ServiceRegistrationHelper.RegisterServices();

            WebApplicationFactory.SetHttpPort(8888);

            MainPage = new MainPage();
        }
    }
}
