using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TVApp.Views;

namespace TVApp
{
    public partial class App : Application
    {
        public App()
        { }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var startView = new LoginView();
            await startView.Dispatcher.InvokeAsync(() => startView.ShowDialog());

            Shutdown();
        }
    }
}
