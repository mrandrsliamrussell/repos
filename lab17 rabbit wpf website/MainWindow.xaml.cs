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

namespace lab17_rabbit_wpf_website
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RabbitButton_Click(object sender, RoutedEventArgs e)
        {
            addRabbit();
        }
        void addRabbit()
        {
            rabbitOutput.Items.Clear();

            Rabbit newrabbit = new Rabbit(0, "");
            newrabbit.name += rabbits.Count().ToString();
            rabbits.Add(newrabbit);

            
                  
                  
                    for (int j = 1; j < rabbits.Count(); j++)
                    {
                        rabbits[j].age += 1;

                    rabbitOutput.Items.Add($"{rabbits[j].name} is {rabbits[j].age}");

                    }
                
            
               
            }
        
    
    }
    public class Rabbit
    {
        public int age { get; set; }
        public string name { get; set; }

        public Rabbit(int age, string counter)
        {
            this.age = 0;
            this.name = $"Rabbit {counter}";
        }

    }

}


