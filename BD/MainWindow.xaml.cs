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

namespace BD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void ShowLevel(int i)
        {
            
            Setup.plocha = hra;
            mapa.VytvorMapu(i-1);
        }

        private void level1_BTN_Click(object sender, RoutedEventArgs e)
        {
            hra.ColumnDefinitions.Clear();
            hra.RowDefinitions.Clear();
            ShowLevel(1);
        }

        private void level2_BTN_Click(object sender, RoutedEventArgs e)
        {
            hra.ColumnDefinitions.Clear();
            hra.RowDefinitions.Clear();
            ShowLevel(2);
        }

        private void level3_BTN_Click(object sender, RoutedEventArgs e)
        {
            hra.ColumnDefinitions.Clear();
            hra.RowDefinitions.Clear();
            ShowLevel(3);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowLevel(1);
        }
        

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Right:
                    Player.GetHrac().Move(0,1);
                    break;
                case Key.Left:
                    Player.GetHrac().Move(0, -1);
                    break;
                case Key.Up:
                    Player.GetHrac().Move(-1, 0);
                    break;
                case Key.Down:
                    Player.GetHrac().Move(1, 0);
                    break;
            }
        }

        
    }
}