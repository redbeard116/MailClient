using System.Windows;

namespace MailClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var view = new MainWindow();
            view.ShowDialog();
        }
    }

}
