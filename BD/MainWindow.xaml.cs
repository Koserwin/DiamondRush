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
        char[,] level1 =
        {
            {'z', 'z','z','z','z','z','z','z','z','z'},
            {'z', 'k','k','z','d','z','d','d','d','z'},
            {'z', 'd','h','z','h','z','k','k','k','z'},
            {'z', 'h','h','h','h','h','h','h','h','z'},
            {'z', 'h','d','h','z','h','h','h','h','z'},
            {'z', 'd','z','P','z','z','h','z','d','z'},
            {'z', 'z','z','z','D','h','h','h','z','z'},
            {'z', 'd','k','k','k','h','z','k','d','z'},
            {'z', 'd','h','h','h','h','h','h','d','z'},
            {'z', 'z','z','z','z','z','z','z','z','z'},
        };

        char[,] level2 =
        {
            {'z', 'z','z','z','z','z','z','z','z','z','z','z','z','z','z','z','z'},
            {'z', 'h','d','h','z','d','d','z','z','z','z','z','k','k','z','z','z'},
            {'z', 'h','z','h','z','d','d','z','z','z','z','z','d','d','d','z','z'},
            {'z', 'P','k','h','z','k','h','h','k','k','z','d','h','h','h','z','z'},
            {'z', 'z','k','d','z','h','h','h','h','d','h','z','d','d','h','z','z'},
            {'z', 'z','d','d','z','h','z','h','z','z','z','z','z','z','h','z','z'},
            {'z', 'k','h','d','z','h','z','h','h','d','z','z','z','z','h','z','z'},
            {'D', 'h','h','h','z','h','z','d','d','d','z','z','z','z','h','z','z'},
            {'z', 'd','z','h','h','h','z','d','d','z','z','z','z','z','h','z','z'},
            {'z', 'z','z','z','h','z','z','z','z','h','k','d','z','z','e','z','z'},
            {'z', 'z','k','k','h','z','z','z','z','d','d','d','z','z','h','h','z'},
            {'z', 'h','h','h','h','h','z','z','z','h','z','z','z','z','h','h','z'},
            {'z', 'd','h','h','h','h','h','h','e','h','h','h','h','h','h','z','z'},
            {'z', 'd','d','h','z','z','z','k','h','d','z','z','z','h','h','z','z'},
            {'z', 'z','z','d','z','z','z','d','d','d','z','z','d','d','d','z','z'},
            {'z', 'z','z','z','z','z','z','z','z','z','z','z','z','z','z','z','z'},
        };

        char[,] level3 =
        {
            {'z', 'z','z','z','z','z','z','z','z','z','z','z','z'},
            {'z', 'z','z','z','z','k','z','z','d','d','z','P','z'},
            {'z', 'd','d','z','h','d','z','h','h','h','h','h','z'},
            {'z', 'd','h','h','h','h','h','h','e','h','h','h','z'},
            {'z', 'd','h','h','e','h','h','h','h','h','h','d','z'},
            {'z', 'h','h','h','z','z','z','h','h','z','d','z','z'},
            {'z', 'z','z','h','d','z','z','h','z','k','k','z','z'},
            {'z', 'z','h','d','d','z','z','h','h','h','d','z','z'},
            {'z', 'z','h','z','z','z','z','h','e','h','d','z','z'},
            {'z', 'z','h','d','z','d','z','h','h','h','z','z','z'},
            {'z', 'z','h','z','z','h','z','z','d','d','z','z','z'},
            {'z', 'h','h','z','z','d','z','z','z','d','z','k','z'},
            {'z', 'z','e','z','z','d','z','z','z','h','h','d','z'},
            {'z', 'k','h','h','h','e','h','h','h','h','d','d','z'},
            {'z', 'd','d','d','z','z','z','h','z','z','z','d','z'},
            {'z', 'h','z','z','z','z','k','d','z','z','z','h','z'},
            {'z', 'h','k','k','z','z','k','h','z','z','k','h','z'},
            {'z', 'h','h','d','z','d','h','h','z','d','h','h','z'},
            {'z', 'h','h','z','z','d','h','h','z','z','h','h','z'},
            {'D', 'd','d','z','z','z','d','d','z','z','z','z','z'},
            {'z', 'h','z','z','z','z','d','z','z','z','z','z','z'},
            {'z', 'z','z','z','z','z','z','z','z','z','z','z','z'},

        };
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ShowLevel(char[,] SelectedLevel)
        {
            char[,] level = SelectedLevel;
            Setup.plocha = hra;
            int radek = level.GetLength(1);
            int sloupec = level.GetLength(0);
            for (int i = 0; i < radek; i++)
            {
                ColumnDefinition c1 = new ColumnDefinition();
                c1.Width = new GridLength(Setup.velikostPole, GridUnitType.Pixel);
                hra.ColumnDefinitions.Add(c1);
            }


            for (int i = 0; i < sloupec; i++)
            {
                RowDefinition r1 = new RowDefinition();
                r1.Height = new GridLength(Setup.velikostPole, GridUnitType.Pixel);
                hra.RowDefinitions.Add(r1);
            }

            for (int s = 0; s < sloupec; s++)
            {
                for (int r = 0; r < radek; r++)
                {
                    Pole p;
                    switch (level[s, r])
                    {
                        case 'z':
                            p = new Wall(r,s);
                            break;
                        case 'P':
                            p = new Player(r, s);
                            break;
                        case 'n':
                            p = new Enemy(r, s);
                            break;
                        case 'd':
                            p = new Diamond(r, s);
                            break;
                        case 'D':
                            p = new Door(r, s);
                            break;
                        case 'k':
                            p = new Rock(r, s);
                            break;
                        case 'h':
                            p = new Dirt(r, s);
                            break;




                    }


                }

            }
        }

        private void level1_BTN_Click(object sender, RoutedEventArgs e)
        {
            hra.ColumnDefinitions.Clear();
            hra.RowDefinitions.Clear();
            ShowLevel(level1);
        }

        private void level2_BTN_Click(object sender, RoutedEventArgs e)
        {
            hra.ColumnDefinitions.Clear();
            hra.RowDefinitions.Clear();
            ShowLevel(level2);
        }

        private void level3_BTN_Click(object sender, RoutedEventArgs e)
        {
            hra.ColumnDefinitions.Clear();
            hra.RowDefinitions.Clear();
            ShowLevel(level3);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowLevel(level1);
        }
    }
}