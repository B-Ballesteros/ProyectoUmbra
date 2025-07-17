using ProyectoUmbra.Helpers;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoUmbra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            Title = ResourceProvider.GetString("MainScreen.Title");
            SubtitleTextBlock.Text = ResourceProvider.GetString("MainScreen.Subtitle");
            StartButton.Content = ResourceProvider.GetString("MainScreen.StartButton");
            HistoryTooltip.Text = ResourceProvider.GetString("MainScreen.HistoryTooltip");
        }

        #region Event Handlers
        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}