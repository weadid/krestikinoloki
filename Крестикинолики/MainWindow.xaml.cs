using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Крестикинолики
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string x = "X";
        public string o = "O";

        
        
        public MainWindow()
        {
            InitializeComponent();

            List<Button> buttonList = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var item in buttonList)
            {
                item.IsEnabled = false;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Start.Background = Brushes.LightBlue;
            Start.Foreground = Brushes.LightBlue;
            List<Button> buttonList = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var item in buttonList)
            {
                item.IsEnabled = true;
            }
            Random(sender);
        }

        static public int bupp = 0;
        private void Random(object sender)
        {
            for (int i = 0; i < 1; i++)
            {
                List<Button> buttonList = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
                Random rnd = new Random();
                int selection = rnd.Next(0, 8);
                if (bupp == 0)
                {
                    bupp = 1;
                    buttonList[selection].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                    Background = Brushes.LightGreen;
                }
            

            
                else if (bupp == 1)
                {
                    bupp = 0;
                    new RoutedEventArgs(ButtonBase.ClickEvent);
                } 
            }
            

            
        }
        
        static public int butt  = 0;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            

            if (butt == 0)
            {
                butt = 1;
                (sender as Button).Content = x;
                
            }
            else if (butt == 1)
            {
                butt = 0;
                (sender as Button).Content = o;

                
            }
            (sender as Button).IsEnabled = false;
            win();
            
        }
        private void win()
        {
            if (button1.Content.ToString() == "X" && button2.Content.ToString() == "X" && button3.Content.ToString() == "X"
               || button4.Content.ToString() == "X" && button5.Content.ToString() == "X" && button6.Content.ToString() == "X"
               || button7.Content.ToString() == "X" && button9.Content.ToString() == "X" && button8.Content.ToString() == "X"
               || button1.Content.ToString() == "X" && button4.Content.ToString() == "X" && button7.Content.ToString() == "X"
               || button2.Content.ToString() == "X" && button5.Content.ToString() == "X" && button8.Content.ToString() == "X"
               || button3.Content.ToString() == "X" && button6.Content.ToString() == "X" && button9.Content.ToString() == "X"
               || button1.Content.ToString() == "X" && button5.Content.ToString() == "X" && button9.Content.ToString() == "X"
               || button3.Content.ToString() == "X" && button5.Content.ToString() == "X" && button7.Content.ToString() == "X")
            {
                
                MessageBox.Show("Player Wins");
                
            }
            else if (button1.Content.ToString() == "O" && button2.Content.ToString() == "O" && button3.Content.ToString() == "O"
            || button4.Content.ToString() == "O" && button5.Content.ToString() == "O" && button6.Content.ToString() == "O"
            || button7.Content.ToString() == "O" && button9.Content.ToString() == "O" && button8.Content.ToString() == "O"
            || button1.Content.ToString() == "O" && button4.Content.ToString() == "O" && button7.Content.ToString() == "O"
            || button2.Content.ToString() == "O" && button5.Content.ToString() == "O" && button8.Content.ToString() == "O"
            || button3.Content.ToString() == "O" && button6.Content.ToString() == "O" && button9.Content.ToString() == "O"
            || button1.Content.ToString() == "O" && button5.Content.ToString() == "O" && button9.Content.ToString() == "O"
            || button3.Content.ToString() == "O" && button5.Content.ToString() == "O" && button7.Content.ToString() == "O")
            {

                
                MessageBox.Show("Computer Wins");
                
            }
            else if (button1.Content.ToString() == "X" && button2.Content.ToString() == "O" && button3.Content.ToString() == "X" && button4.Content.ToString() == "X" && button5.Content.ToString() == "O" && button6.Content.ToString() == "X" && button7.Content.ToString() == "O" && button8.Content.ToString() == "X" && button9.Content.ToString() == "O"
            || button1.Content.ToString() == "X" && button2.Content.ToString() == "O" && button3.Content.ToString() == "X" && button4.Content.ToString() == "X" && button5.Content.ToString() == "O" && button6.Content.ToString() == "O" && button7.Content.ToString() == "O" && button8.Content.ToString() == "X" && button9.Content.ToString() == "X"
            || button1.Content.ToString() == "O" && button2.Content.ToString() == "O" && button3.Content.ToString() == "X" && button4.Content.ToString() == "X" && button5.Content.ToString() == "X" && button6.Content.ToString() == "O" && button7.Content.ToString() == "O" && button8.Content.ToString() == "X" && button9.Content.ToString() == "X"
            || button1.Content.ToString() == "X" && button2.Content.ToString() == "O" && button3.Content.ToString() == "O" && button4.Content.ToString() == "O" && button5.Content.ToString() == "X" && button6.Content.ToString() == "X" && button7.Content.ToString() == "X" && button8.Content.ToString() == "X" && button9.Content.ToString() == "O"
            || button1.Content.ToString() == "X" && button2.Content.ToString() == "O" && button3.Content.ToString() == "X" && button4.Content.ToString() == "X" && button5.Content.ToString() == "X" && button6.Content.ToString() == "O" && button7.Content.ToString() == "O" && button8.Content.ToString() == "X" && button9.Content.ToString() == "O"
            || button1.Content.ToString() == "X" && button2.Content.ToString() == "X" && button3.Content.ToString() == "O" && button4.Content.ToString() == "O" && button5.Content.ToString() == "O" && button6.Content.ToString() == "X" && button7.Content.ToString() == "X" && button8.Content.ToString() == "O" && button9.Content.ToString() == "X"
            || button1.Content.ToString() == "O" && button2.Content.ToString() == "X" && button3.Content.ToString() == "O" && button4.Content.ToString() == "O" && button5.Content.ToString() == "X" && button6.Content.ToString() == "X" && button7.Content.ToString() == "X" && button8.Content.ToString() == "O" && button9.Content.ToString() == "X"
            || button1.Content.ToString() == "X" && button2.Content.ToString() == "O" && button3.Content.ToString() == "X" && button4.Content.ToString() == "O" && button5.Content.ToString() == "X" && button6.Content.ToString() == "X" && button7.Content.ToString() == "O" && button8.Content.ToString() == "X" && button9.Content.ToString() == "O"
            || button1.Content.ToString() == "O" && button2.Content.ToString() == "X" && button3.Content.ToString() == "X" && button4.Content.ToString() == "X" && button5.Content.ToString() == "O" && button6.Content.ToString() == "O" && button7.Content.ToString() == "X" && button8.Content.ToString() == "O" && button9.Content.ToString() == "X"
            || button1.Content.ToString() == "X" && button2.Content.ToString() == "X" && button3.Content.ToString() == "O" && button4.Content.ToString() == "O" && button5.Content.ToString() == "X" && button6.Content.ToString() == "X" && button7.Content.ToString() == "X" && button8.Content.ToString() == "O" && button9.Content.ToString() == "O"
            || button1.Content.ToString() == "X" && button2.Content.ToString() == "O" && button3.Content.ToString() == "O" && button4.Content.ToString() == "O" && button5.Content.ToString() == "X" && button6.Content.ToString() == "X" && button7.Content.ToString() == "O" && button8.Content.ToString() == "X" && button9.Content.ToString() == "O")
            {
                MessageBox.Show("Draw Wins");
            }
        }

    }
}
