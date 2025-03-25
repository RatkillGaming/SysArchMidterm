using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SysArchPrelim
{
    public partial class Form1 : Form
    {
        private DBConnect dbConnect;

        public Form1()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dbConnect.OpenConnection();
                string query = "SELECT * FROM Department";
                OleDbDataReader reader = dbConnect.ExecuteQuery(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                DepartmentDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbConnect.CloseConnection();
            }
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRadioButton.Checked)
            {
                try
                {
                    dbConnect.OpenConnection();
                    string query = $"INSERT INTO Department (CollegeID, DepartmentName, DepartmentCode, IsActive) VALUES ({CollegeIDTextBox.Text}, '{DepartmentNameTextBox.Text}', '{DepartmentCodeTextBox.Text}', {IsActiveCheckBox.Checked})";
                    dbConnect.ExecuteNonQuery(query);
                    MessageBox.Show("Record added successfully!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    dbConnect.CloseConnection();
                }
            }
        }

        private void UpdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateRadioButton.Checked)
            {
                try
                {
                    dbConnect.OpenConnection();
                    string query = $"UPDATE Department SET CollegeID={CollegeIDTextBox.Text}, DepartmentName='{DepartmentNameTextBox.Text}', DepartmentCode='{DepartmentCodeTextBox.Text}', IsActive={IsActiveCheckBox.Checked} WHERE DepartmentID={DepartmentIDTextBox.Text}";
                    dbConnect.ExecuteNonQuery(query);
                    MessageBox.Show("Record updated successfully!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    dbConnect.CloseConnection();
                }
            }
        }

        private void DeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteRadioButton.Checked)
            {
                try
                {
                    dbConnect.OpenConnection();
                    string query = $"DELETE FROM Department WHERE DepartmentID={DepartmentIDTextBox.Text}";
                    dbConnect.ExecuteNonQuery(query);
                    MessageBox.Show("Record deleted successfully!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    dbConnect.CloseConnection();
                }
            }
        }

        private void RetrieveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RetrieveRadioButton.Checked)
            {
                try
                {
                    dbConnect.OpenConnection();
                    string query = $"SELECT * FROM Department WHERE DepartmentID={DepartmentIDTextBox.Text}";
                    OleDbDataReader reader = dbConnect.ExecuteQuery(query);
                    if (reader.Read())
                    {
                        CollegeIDTextBox.Text = reader["CollegeID"].ToString();
                        DepartmentNameTextBox.Text = reader["DepartmentName"].ToString();
                        DepartmentCodeTextBox.Text = reader["DepartmentCode"].ToString();
                        IsActiveCheckBox.Checked = (bool)reader["IsActive"];
                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    dbConnect.CloseConnection();
                }
            }
        }

        private void CollegeFormBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}