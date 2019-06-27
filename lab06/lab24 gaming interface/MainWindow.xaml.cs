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
using System.IO;

namespace lab24_gaming_interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists("Title.txt"))
            {
                WelcomeLabel.Content = File.ReadAllText("Title.txt");
                InputName.Text = WelcomeLabel.Content.ToString();
            }
            else
            {
                File.Create("Title.txt");
            }
        }

        // when key up event takes place object will be item which caused the event i.e the key we pressed eg letter 'h' evernt args is 
        // an array of strings which contains any relevent data for that event
        private void KeyUp_ChangeTitle(object sender, EventArgs e)
        {
            WelcomeLabel.Content = InputName.Text;
           
            File.WriteAllText("Title.txt", InputName.Text);
        }
       

        private void MouseEnterBox(object sender, EventArgs e)
        {
            WelcomeLabel.Visibility = 0F;
        }

        private void EditMode_Checked(object sender, RoutedEventArgs e)
        {
            if (EditMode.IsChecked == true)
            {
                InputName.IsReadOnly = false;
            }
            else
            {
                InputName.IsReadOnly = true;
            }
        }
    }
}
