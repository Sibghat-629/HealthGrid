using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospitalinventorysystem
{
    public partial class Hospitall : Form
    {
        public Hospitall()
        {
            InitializeComponent();
            displayhospital();
        }
        readonly SqlConnection connection = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");


        private void displayhospital()
        {
            try
            {
                connection.Open();
                string Query = "select * from Hospitalsss";
                SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
                connection.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hid.Text == " " || hname.Text == " " || branches.Text == "  " || founded.Text == " " || area.Text == "  ")
                {
                    MessageBox.Show("missing information");
                }
                else
                {
                    connection.Open();
                    string query = "insert into Hospitalsss Values( ' " + hid.Text + " ' ,  ' " + hname.Text + " ' , ' " + branches.Text + " ' , ' " + founded.Text + " ' , ' " + area.Text + " ' )";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record entered successfully");
                    displayhospital();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hid.Text == " " || hname.Text == " " || branches.Text == " " || founded.Text == "  " || area.Text == " " )
                {
                    MessageBox.Show("missing information");
                }

                else
                {
                    connection.Open();
                    string query = "update Hospitalsss Set Hname = @Hname , Branches = @Branches , Founded = @Founded , Area = @Area where Hospitalid = @Hospitalid";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Hname", hname.Text);
                    cmd.Parameters.AddWithValue("@Branches", branches.Text);
                    cmd.Parameters.AddWithValue("@Founded", founded.Text);
                    cmd.Parameters.AddWithValue("@Area", area.Text);
                    cmd.Parameters.AddWithValue("@Hospitalid", hid.Text);



                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record updated successfully");
                    displayhospital();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hid.Text == " ")
                {
                    MessageBox.Show("enter the hospital id");
                }
                else
                {
                    connection.Open();
                    string query = "delete from Hospitalsss where Hospitalid=' " + hid.Text + " '  ";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record deleted successfully");
                    displayhospital();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            hid.Text = " ";
            hname.Text = " ";
            branches.Text = " ";
            founded.Text = " ";
           
            area.Text = " ";
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                hid.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                hname.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                branches.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
               founded.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                area.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                connection.Close();
            }
        }

        private void Hospitall_Load(object sender, EventArgs e)
        {
            displayhospital();
        }
    }
}
