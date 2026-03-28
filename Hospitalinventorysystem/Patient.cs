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
using System.Xml.Linq;

namespace Hospitalinventorysystem
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            displaypatient();
        }

        private void cross_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        readonly SqlConnection connection = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");


        private void displaypatient()
        {
            try
            {
                connection.Open();
                string Query = "select * from patients";
                SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
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

        private void Patient_Load(object sender, EventArgs e)
        {
            displaypatient();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (pid.Text == " " || patname.Text == " " || address.Text == "  " ||  age.Text == " " || phone.Text == "  " || pgender.Text == " " || bloodgroup.Text == " " || disease.Text == "  ")
                {
                    MessageBox.Show("missing information");
                }

                else
                {
                    connection.Open();
                    string query = "insert into patients Values( ' " + pid.Text + " ' ,  ' " + patname.Text + " ' , ' " + address.Text + " ' , ' " + age.Text + " ' , ' " + phone.Text + " ' , ' " + pgender.Text + " ' , ' " + bloodgroup.Text + " ' , ' " + disease.Text + " ')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record entered successfully");
                    displaypatient();


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

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (pid.Text == " " || patname.Text == " " || address.Text == " " || age.Text == "  " || phone.Text == " " || pgender.Text == " " || bloodgroup.Text == "  " || disease.Text == " ")
                {
                    MessageBox.Show("missing information");
                }

                else
                {
                    connection.Open();
                    string query = "update patients Set  pName = @pName , paddress = @paddress , pAge = @pAge , Pphone = @Pphone , pGen = @pGen , Pbloodgroup = @Pbloodgroup , Pmajordisease = @Pmajordisease where pid = @pid";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@pName", patname.Text);
                    cmd.Parameters.AddWithValue("@paddress", address.Text);
                    cmd.Parameters.AddWithValue("@pAge", age.Text);
                    cmd.Parameters.AddWithValue("@Pphone", phone.Text);
                    cmd.Parameters.AddWithValue("@pGen", pgender.Text);
                    cmd.Parameters.AddWithValue("@Pbloogroup", bloodgroup.Text);
                    cmd.Parameters.AddWithValue("@Pmajordisease", disease.Text);
                    cmd.Parameters.AddWithValue("@pid",pid.Text);


                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record updated successfully");
                    displaypatient();


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

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (pid.Text == " ")
                {
                    MessageBox.Show("enter the patient id");
                }
                else
                {
                    connection.Open();
                    string query = "delete from patients where pid=' " + pid.Text + " '  ";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record deleted successfully");
                    displaypatient();

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

        private void reset_button_Click(object sender, EventArgs e)
        {
            pid.Text = " ";
            patname.Text = " ";
            address.Text = " ";
            age.Text = " ";
            phone.Text = " ";
            pgender.Text = " ";
            bloodgroup.Text = " ";
            disease.Text = " ";

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pid.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                patname.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                address.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                age.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                phone.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                pgender.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                bloodgroup.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                disease.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
                


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

        private void home_button_Click(object sender, EventArgs e)
        {
            menu ob = new menu();
            ob.Show();
            this.Hide();
        }


    }
}
