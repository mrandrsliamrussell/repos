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
using System.Windows.Shapes;

namespace lab24_gaming_interface
{
    /// <summary>
    /// Interaction logic for PongGame.xaml
    /// </summary>
    public partial class PongGame : Window
    {
        double XVelocity = 4, YVelocity = 4, angle = 0;
        double x = 0, y = 0;
        public PongGame()
        {
            InitializeComponent();
            Task task = Task.Run(() =>
            {
                mainGrid.Dispatcher.BeginInvoke(new Action(() => BallController()));
            });
           // await task;
        }

        private void P1KeyPress(object sender, EventArgs e)
        {
            // MessageBox.Show("P1 key press");
            Thickness p1Thickness = new Thickness(Player1.Margin.Left, Player1.Margin.Top, Player1.Margin.Right, Player1.Margin.Bottom);
            Thickness p2Thickness = new Thickness(Player2.Margin.Left, Player2.Margin.Top, Player2.Margin.Right, Player2.Margin.Bottom);
            if (Keyboard.IsKeyDown(Key.Q))
            {
                p1Thickness = new Thickness(Player1.Margin.Left, Player1.Margin.Top + 5, Player1.Margin.Right, Player1.Margin.Bottom - 5);

            }
            if (Keyboard.IsKeyDown(Key.A))
            {
                p1Thickness = new Thickness(Player1.Margin.Left, Player1.Margin.Top - 5, Player1.Margin.Right, Player1.Margin.Bottom + 5);
            }
            if (Keyboard.IsKeyDown(Key.O))
            {
                p2Thickness = new Thickness(Player2.Margin.Left, Player2.Margin.Top + 5, Player2.Margin.Right, Player2.Margin.Bottom - 5);
            }
            if (Keyboard.IsKeyDown(Key.L))
            {
                p2Thickness = new Thickness(Player2.Margin.Left, Player2.Margin.Top - 5, Player2.Margin.Right, Player2.Margin.Bottom + 5);
            }

            Player1.Margin = p1Thickness;
            Player2.Margin = p2Thickness;


        }
        

        private async void BallController()
        {                     
            if(Ball.Margin.Left < Player1.Margin.Right)
            {
                angle = 180 - angle;
            }
            if(Ball.Margin.Right > Player2.Margin.Left)
            {
                angle = 180 - angle;
            }           

            if (Ball.Margin.Left < 0 || Ball.Margin.Left > mainGrid.ColumnDefinitions[1].Width.Value)
            {
                angle = 180 - angle;
            }
            else if (Ball.Margin.Top < 0 || Ball.Margin.Top > mainGrid.RowDefinitions[1].Height.Value)
            {
                angle = 360 - angle;
            }
            XVelocity += XVelocity * Math.Cos(angle * Math.PI / 180);
            YVelocity += XVelocity * Math.Sin(angle * Math.PI / 180);
            XVelocity = 2;
            YVelocity = 2;
            Thickness BallThickness = new Thickness(Ball.Margin.Left + XVelocity, Ball.Margin.Top + YVelocity, Ball.Margin.Right - XVelocity, Ball.Margin.Bottom - YVelocity);
            
        }

       
    }
}
