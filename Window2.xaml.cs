using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow m1 = new MainWindow();
            m1.Show();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Addbutton1();
           
            
        }
        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Deletebutton();
        }
      
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Homebutton();   
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Printbutton();
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Main.Content = new View();
        }

        private void Main_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
           
        }
    }
}