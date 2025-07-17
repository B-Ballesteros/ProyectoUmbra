using System.Configuration;
using System.Data;
using System.Windows;

namespace ProyectoUmbra
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
#if DEBUG
            var colorDict = new ResourceDictionary
            {
                Source = new Uri("Resources/Colors.Local.xaml", UriKind.Relative)
            };
#else
            var colorDict = new ResourceDictionary
            {
                Source = new Uri("Resources/Colors.Release.xaml", UriKind.Relative)
            };
#endif
            Resources.MergedDictionaries.Add(colorDict);
        }
    }

}
