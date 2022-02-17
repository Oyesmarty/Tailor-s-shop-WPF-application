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
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlTypes;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Addbutton1.xaml
    /// </summary>
    public partial class Addbutton1 : UserControl
    {
        public Addbutton1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name.Clear();
            contact.Clear();
            address.Clear();
            length.Clear();
            sleevslenght.Clear();
            sleevsbottom.Clear();
            frontneck.Clear();
            hipp.Clear();
            shoulder.Clear();
            waist.Clear();
            hipplength.Clear();
            backneck.Clear();
            waistlenght.Clear();
            chest.Clear();
            upperchest.Clear();
            dotpoint.Clear();
            lenght1.Clear();
            bottom.Clear();
            knee.Clear();
            thighs.Clear();
            waist1.Clear();
            

        }
        protected void DatePicker (object sender, EventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Smarty\source\repos\Project1\WpfApp1\Database1.mdf;Integrated Security=True");
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Table](name,contact,address,length,sleevslength,sleevsbottom,frontneck,hipp,shoulder,waist,hipplength,backneck,waistlength,chest,upperchest,dotpoint,lenght1,bottom,knee,thighs,waist1,tdate,orders,TOPorBLOUSE,pant)VALUES ('" + name.Text + "','" + contact.Text + "','" + address.Text + "','" + length.Text + "','" + sleevslenght.Text + "','" + sleevsbottom.Text + "','" + frontneck.Text + "','" + hipp.Text + "','" + shoulder.Text + "','" + waist.Text + "','" + hipplength.Text + "','" + backneck.Text + "','" + waistlenght.Text + "','" + chest.Text + "','" + upperchest.Text + "','" + dotpoint.Text + "','" + lenght1.Text + "','" + bottom.Text + "','" + knee.Text + "','" + thighs.Text + "','" + waist1.Text + "','"+tdate.Text +"','"+orders.Text+"','"+TOPorBLOUSE.Text+"','"+pant.Text+"')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Press CLEAR to Add new Record");
            }
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            {
               
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(add, "Entries");
                }

            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
