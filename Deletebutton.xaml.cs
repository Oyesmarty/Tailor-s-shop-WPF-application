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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Deletebutton.xaml
    /// </summary>
    public partial class Deletebutton : UserControl
    {
        public Deletebutton()
        {
            InitializeComponent();
            using (AppDbContext db = new AppDbContext())
            {
                Recordtable.ItemsSource = db.Table.ToList();
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
