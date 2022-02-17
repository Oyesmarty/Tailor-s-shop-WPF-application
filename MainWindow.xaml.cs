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

namespace WpfApp1
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

       
        private void CLEAR_Click(object sender, RoutedEventArgs e)
        {
                ENTER_ID.Clear();
                ENTER_PASS.Clear();                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Userid, Password;
            Userid = ENTER_ID.Text;
            Password = ENTER_PASS.Password;
            if (Userid == "Sahil"&& Password == "sahil786") 
            {
                MessageBox.Show("Login Sucessful");
                this.Hide();
                Window2 w1 = new Window2();
                w1.ShowDialog();
            }  
            else
            {
                MessageBox.Show("UserId or Password is Incorrect");
            }
        }
    }
}
