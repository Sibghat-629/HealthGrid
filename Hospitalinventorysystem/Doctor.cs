using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitalinventorysystem
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }
        readonly SqlConnection connection = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");
        

        private void displaydoctor()
        {
            try
            {
                connection.Open();
                string Query = "select * from Doctors";
                SqlDataAdapter sda = new SqlDataAdapter(Query,connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();





            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }

        }


        
        private void cross_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(id.Text == " "  ||  name.Text == " " || gender.Text == " " ||  exp.Text == "  "  || lis.Text == " ")
                {
                    MessageBox.Show("missing information");
                }

                else
                {
                    connection.Open();
                    string query = "insert into Doctors Values(' " + id.Text + " ',  ' " + name.Text + " ',' " + gender.Text + " ',' " + exp.Text + " ',' " + lis.Text + " ')";
                    SqlCommand cmd = new SqlCommand(query,connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record entered successfully");
                    displaydoctor();


                }
            }
            catch( Exception ex ) {
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                connection.Close() ;
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            id.Text = " ";
            name.Text = " ";
            gender.Text = " ";
            exp.Text = " ";
            lis.Text = " ";

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(id.Text == " ")
                {
                    MessageBox.Show("enter the doctor id");
                }
                else
                {
                    connection.Open();
                    string query = "delete from Doctors where Docid=' " + id.Text + " '  ";
                    SqlCommand command = new SqlCommand(query,connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record deleted successfully");
                    displaydoctor();

                }
            }
            catch(Exception ex)
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
                if (id.Text == " " || name.Text == " " || gender.Text == " " || exp.Text == " " || lis.Text == " ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    connection.Open();
                    string query = "update Doctors Set Docname = @Docname ,Gender = @Gender  , Experience = @Experience , Lisence = @Lisence where Docid = @Docid";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Docname", name.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender.Text);
                    cmd.Parameters.AddWithValue("@Experience", exp.Text);
                    cmd.Parameters.AddWithValue("@Lisence", lis.Text);
                    cmd.Parameters.AddWithValue("@Docid", id.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record updated successfully");
                    displaydoctor();


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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                gender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                exp.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                lis.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


            }
            catch( Exception ex )
            {
                MessageBox.Show (ex.Message );

            }
            finally
            {

                  connection.Close();
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            displaydoctor();
        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            menu ob = new menu();
            ob.Show();
            this.Hide();
        }


    }
}
