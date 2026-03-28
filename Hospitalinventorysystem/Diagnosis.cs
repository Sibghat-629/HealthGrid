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
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
            displaydiagnosis();
        }

        readonly SqlConnection connection = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");


        private void displaydiagnosis()
        {
            try
            {
                connection.Open();
                string Query = "select * from Diagnosiss";
                SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
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
        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (did.Text == " " || pid.Text == " " ||  patientname.Text == " " || symptoms.Text == "  " || dtest.Text == " " || medicines.Text == " ")
                {
                    MessageBox.Show("missing information");
                }

                else
                {
                    connection.Open();
                    string query = "insert into Diagnosiss Values(' " + did.Text + " ',  ' " + pid.Text + " ',' " + patientname.Text + " ',' " + symptoms.Text + " ',' " + dtest.Text + " ', ' " + medicines.Text + " ')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record entered successfully");
                    displaydiagnosis();


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
                if (did.Text == " " || pid.Text == " " || patientname.Text == " " || symptoms.Text == " " || dtest.Text == " " || medicines.Text == "  ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    connection.Open();
                    string query = "update Diagnosiss Set Patientid = @Patientid , Patientname = @Patientname , Symptoms = @Symptoms , Diagnosistest = @Diagnosistest , Medicines = @Medicines where Did = @Did";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Patientid", pid.Text);
                    cmd.Parameters.AddWithValue("@Patientname", patientname.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", symptoms.Text);
                    cmd.Parameters.AddWithValue("@Diagnosistest", dtest.Text);
                    cmd.Parameters.AddWithValue("@Medicines", medicines.Text);
                    cmd.Parameters.AddWithValue("@Did", did.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record updated successfully");
                    displaydiagnosis();


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
            did.Text = " ";
            pid.Text = " "; 
            patientname.Text = " ";
            symptoms.Text = " ";
            dtest.Text = " ";
            medicines.Text = " ";

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (did.Text == " ")
                {
                    MessageBox.Show("enter the diagnosis id");
                }
                else
                {
                    connection.Open();
                    string query = "delete from Diagnosiss where Did=' " + did.Text + " '  ";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("record deleted successfully");
                    displaydiagnosis();

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

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                did.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                pid.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                patientname.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                symptoms.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                dtest.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                medicines.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();


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

       


        void displaypatientid()
        {
            string sql = "select * from patients";
            SqlCommand cmd = new SqlCommand(sql,connection);
            SqlDataReader rdr;
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("pid" , typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                pid.ValueMember = "pid";
                pid.DataSource = dt;
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

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            displaypatientid();
        }




        string pname;
        
        void displaypatientname()
        {
            try
            {
                connection.Open();
                string ss = "select * from patients  Where  pid = " + pid.SelectedValue.ToString();
                SqlCommand sqlCommand = new SqlCommand(ss,connection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    pname = dr["pName"].ToString();
                    patientname.Text = pname;



                }
                connection.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close() ;
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            menu ob = new menu();
            ob.Show();
            this.Hide();
        }

        private void pid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            displaypatientname();
        }
    }


}
