using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SysArchPrelim
{
    public partial class Form2 : Form
    {
        private DBConnect dbConnect;

        public Form2()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dbConnect.OpenConnection();
                string query = "SELECT * FROM College";
                OleDbDataReader reader = dbConnect.ExecuteQuery(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                CollegeDataGridView.DataSource = dt;
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

        private void AddRadioButtonCollege_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRadioButtonCollege.Checked)
            {
                try
                {
                    dbConnect.OpenConnection();
                    string query = $"INSERT INTO College (CollegeName, CollegeCode, IsActive) VALUES ('{CollegeNameTextBox.Text}', '{CollegeCodeTextBox.Text}', {CollegeIsActiveCheckBox.Checked})";
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

        private void UpdateRadioButtonCollege_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateRadioButtonCollege.Checked)
            {
                try
                {
                    dbConnect.OpenConnection();
                    string query = $"UPDATE College SET CollegeName='{CollegeNameTextBox.Text}', CollegeCode='{CollegeCodeTextBox.Text}', IsActive={CollegeIsActiveCheckBox.Checked} WHERE CollegeID={CollegeIDTextBox.Text}";
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

        private void DeleteRadioButtonCollege_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteRadioButtonCollege.Checked)
            {
                try
                {
                    dbConnect.OpenConnection();
                    string query = $"DELETE FROM College WHERE CollegeID={CollegeIDTextBox.Text}";
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

        private void RetrieveRadioButtonCollege_CheckedChanged(object sender, EventArgs e)
        {
            if (RetrieveRadioButtonCollege.Checked)
            {
                try
                {
                    dbConnect.OpenConnection();
                    string query = $"SELECT * FROM College WHERE CollegeID={CollegeIDTextBox.Text}";
                    OleDbDataReader reader = dbConnect.ExecuteQuery(query);
                    if (reader.Read())
                    {
                        CollegeNameTextBox.Text = reader["CollegeName"].ToString();
                        CollegeCodeTextBox.Text = reader["CollegeCode"].ToString();
                        CollegeIsActiveCheckBox.Checked = (bool)reader["IsActive"];
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

        private void DepartmentFormBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void CollegeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CollegeDataGridView.Rows[e.RowIndex];
                CollegeIDTextBox.Text = row.Cells["CollegeID"].Value.ToString();
                CollegeNameTextBox.Text = row.Cells["CollegeName"].Value.ToString();
                CollegeCodeTextBox.Text = row.Cells["CollegeCode"].Value.ToString();
                CollegeIsActiveCheckBox.Checked = (bool)row.Cells["IsActive"].Value;
            }
        }
    }
}