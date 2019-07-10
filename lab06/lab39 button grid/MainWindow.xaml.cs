using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab39_button_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttons = new List<Button>();
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            for(int i = 0; i < 100; i++)
            {
                var b = new Button();
                b.Name = "Button" + (i + 1);
                b.Content = "Button" + (i + 1);
                b.Click += new RoutedEventHandler(button_click);

                mainGrid.Children.Add(b);
                Grid.SetColumn(b, i % 10);
                Grid.SetRow(b, i / 10);

                System.Threading.Thread.Sleep(20);
                Color newColour = (Color)ColorConverter.ConvertFromString(RandomNumberGenerator().ToString());
                SolidColorBrush brush = new SolidColorBrush(newColour);
                b.Background = brush;
                buttons.Add(b);
            }
        }
        private void button_click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            
            MessageBox.Show("youve clicked a button" + b.Name + Grid.GetColumn(b) + Grid.GetRow(b) );
            Color newColour = (Color)ColorConverter.ConvertFromString(RandomNumberGenerator().ToString());
            SolidColorBrush brush = new SolidColorBrush(newColour);
            b.Background = brush;
        }
         private colours RandomNumberGenerator()
        {
            Random rand = new Random();

            return (colours)rand.Next(0,6);
        }
        enum colours
        {
            Blue = 0, Red = 1, Green = 2, Purple = 3, Pink = 4, Orange = 5
        }
    }
}
