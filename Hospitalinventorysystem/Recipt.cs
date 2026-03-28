using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitalinventorysystem
{
    public partial class Recipt : Form
    {
        public Recipt()
        {
            InitializeComponent();
            displayrecipts();
        }


        readonly SqlConnection connection = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");


        private void displayrecipts()
        {
            try
            {
                connection.Open();
                string Query = "select * from Recipts";
                SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView10.DataSource = ds.Tables[0];
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

        private void addbuttons_Click(object sender, EventArgs e)
        {
            try
            {
                if (rid.Text == " " || results.Text == "  " || bill.Text == " ")
                {
                    MessageBox.Show("missing information");
                }

                else
                {
                    connection.Open();
                    string query = "insert into  Recipts Values(' " + rid.Text + " ',' " + results.Text + " ',' " + bill.Text + " ')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record entered successfully");
                    displayrecipts();


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

        private void updatebuttons_Click(object sender, EventArgs e)
        {
            try
            {
                if (rid.Text == " " || results.Text == " " || bill.Text == " ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    connection.Open();
                    string query = "update Recipts Set  Results = @Results , Bill = @Bill where Rid = @Rid";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Results", results.Text);
                    cmd.Parameters.AddWithValue("@Bil", bill.Text);
                    cmd.Parameters.AddWithValue("@Rid", rid.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record updated successfully");
                    displayrecipts();


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

        private void deletebuttons_Click(object sender, EventArgs e)
        {
            try
            {
                if (rid.Text == " ")
                {
                    MessageBox.Show("enter the Recipt id");
                }
                else
                {
                    connection.Open();
                    string query = "delete from Recipts where Rid=' " + rid.Text + " '  ";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record deleted successfully");
                    displayrecipts();

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

        private void resetbuttons_Click(object sender, EventArgs e)
        {
            rid.Text = " ";
            results.Text = " ";
            bill.Text = " ";
          
        }

        private void dataGridView10_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                rid.Text = dataGridView10.SelectedRows[0].Cells[0].Value.ToString();
                results.Text = dataGridView10.SelectedRows[0].Cells[1].Value.ToString();
                bill.Text = dataGridView10.SelectedRows[0].Cells[2].Value.ToString();
       


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

        private void Recipt_Load(object sender, EventArgs e)
        {
            displayrecipts();
        }


       

        
    }
}
