using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Printbutton.xaml
    /// </summary>
    public partial class Printbutton : UserControl
    {
        public Printbutton()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "Invoice");
                }

            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Smarty\source\repos\Project1\WpfApp1\Database1.mdf;Integrated Security=True");
            try
            {
                SqlCommand cnd = new SqlCommand("INSERT INTO [Print](name,address,contact,clothes,clothescost,materialcost,othercost,totalbill,advancepaid,amountpayable)VALUES('" + name.Text + "','"+ address.Text +"','"+ contact.Text+"','"+ clothes.Text +"','"+ clothescost.Text +"','"+ material_cost.Text +"','"+ other_cost.Text +"','"+ total_bill.Text+"','"+ advance_paid.Text+"','"+ amount_payable.Text+"')",conn);
                conn.Open();
                cnd.ExecuteNonQuery();
                MessageBox.Show("Record Added");
            }
            catch(SqlException ax)
            {
                MessageBox.Show("Error" + ax);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Press Clear to add new");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            name.Clear();
            contact.Clear();
            address.Clear();
            clothes.Clear();
            clothescost.Clear();
            material_cost.Clear();
            other_cost.Clear();
            total_bill.Clear();
            advance_paid.Clear();
            amount_payable.Clear();
            
        }
    }
}
