﻿using System;
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

namespace lab37_WPF_grid_click
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
            for( int i =0; i<9; i++)
            {
                var b = new Button();
                b.Name = "Button" + i.ToString();
                
                b.Content = i;
                mainGrid.Children.Add(b);
                Grid.SetColumn(b, i%3);
                Grid.SetRow(b, i/3);
                buttons.Add(b);
            }
        }
        private void DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("you double clicked");
        }
    }
}
