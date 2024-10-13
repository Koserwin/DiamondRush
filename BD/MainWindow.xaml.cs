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
            {'z', 'z','z','z','D','h','h','z','z','z'},
            {'z', 'd','k','k','k','h','z','k','d','z'},
            {'z', 'd','h','h','h','h','h','h','d','z'},
            {'z', 'z','z','z','z','z','z','z','z','z'},
        };
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Setup.plocha = hra;
            int radek = level1.GetLength(1);
            int sloupec = level1.GetLength(0);
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
                    switch (level1[s, r])
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

        

    }
}