using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEFExample
{
    public partial class Form1 : Form
    {
        #region Initialization, functions and constants
        readonly string newMessage = Environment.NewLine +
            "---------------------------------------------------------------------------" +
            Environment.NewLine;

        private void reconstructList()
        {
            try
            {
                employeesList.Items.Clear();
                var list = ReadEmployee(Convert.ToInt32(numericIDReadFrom.Minimum), Convert.ToInt32(numericIDReadTo.Maximum));
                employeesList.Items.AddRange(list.ToArray());
            }
            catch (Exception ex)
            {
                textOutput.AppendText("Unknown error has occurred while building elements for Delete operation. Delete operation is blocked." + newMessage);
            }
            finally
            { }
        }

        public Form1()
        {
            InitializeComponent();
            checkIDRead.Checked = true;
        }
        #endregion
        #region CRUD functions

        public bool DeleteEmployee(int ID)
        {
            try
            {
                using (CRUDEFEntities dbContext = new CRUDEFEntities())
                {
                    var query = dbContext.Employees.SingleOrDefault(x => x.ID == ID);

                    if (query == null)
                        return false;

                    dbContext.Employees.Remove(query);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            { throw; }
            return true;
        }

        public void CreateEmployee(int ID, string fullname)
        {
            try
            {
                using (CRUDEFEntities dbContext = new CRUDEFEntities())
                {
                    var emp = new Employee();

                    emp.ID = ID;
                    emp.FullName = fullname;
                    dbContext.Employees.Add(emp);
                    dbContext.SaveChanges();

                }
            }
            catch (Exception)
            { throw; }
        }



        public List<Employee> ReadEmployee(int IDFrom, int IDTo, string fullname = null)
        {
            try
            {
                using (CRUDEFEntities dbContext = new CRUDEFEntities())
                {
                    IQueryable<Employee> query = dbContext.Employees.Where(x => x.ID >= IDFrom && x.ID <= IDTo);
                    if (!String.IsNullOrWhiteSpace(fullname)) query = query.Where(x => x.FullName == fullname);
                    return query.OrderBy(x => x.ID).ToList();
                }
            }
            catch (Exception)
            { throw; }
        }

        public bool UpdateEmployee(int ID, string newFullName)
        {
            using (var dbContext = new CRUDEFEntities())
            {
                var query = dbContext.Employees.SingleOrDefault(x => x.ID == ID);
                if (query == null)
                    return false;

                if (!String.IsNullOrWhiteSpace(newFullName) )
                    query.FullName = newFullName;
                dbContext.SaveChanges();
                return true;
            }
        }
        #endregion
        #region UI eventhandlers

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;

                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(openFileDialog1.FileName, true))
                    {
                        file.WriteLine("Logging CRUD EF+Cache application file, " + DateTime.Now + newMessage
                            + textOutput.Text + newMessage);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error writing log to file. Check if file still exists or you have enough permissions to write into it.");
            }




        }


        private void tabCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabCRUD.SelectedIndex)
            {
            case 1: 
                this.AcceptButton = readButton;
                break;
            case 2: 
                this.AcceptButton = updateButton;
                break;
            case 3: 
                this.AcceptButton = deleteButton;
                break;
            case 0: 
                this.AcceptButton = createButton;
                break;
            }
            reconstructList();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            updateButton.Enabled = !(String.IsNullOrWhiteSpace(textFullNameUpdate.Text));
        }

        private void textFullNameCreate_TextChanged(object sender, EventArgs e)
        {
            createButton.Enabled = !(String.IsNullOrWhiteSpace(textFullNameCreate.Text));
        }

        private void numericIDReadFrom_ValueChanged(object sender, EventArgs e)
        {
            numericIDReadTo.Minimum = numericIDReadFrom.Value;
        }

        private void numericIDReadTo_ValueChanged(object sender, EventArgs e)
        {
            numericIDReadFrom.Maximum = numericIDReadTo.Value;
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
        }

        private void checkIDRead_CheckedChanged(object sender, EventArgs e)
        {
            numericIDReadFrom.Enabled = checkIDRead.Checked;
            numericIDReadTo.Enabled = checkIDRead.Checked;
        }

        #endregion
        #region Button handlers
        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                textOutput.AppendText("Selecting data from table 'Employee'" + Environment.NewLine
                    + (checkIDRead.Checked ?
                    "from ID = " + numericIDReadFrom.Value + ", to ID = " + numericIDReadTo.Value 
                    : "no ID condition specified")
                    + Environment.NewLine + "full name is "
                    + (String.IsNullOrEmpty(textFullNameRead.Text) ?
                    "'" + textFullNameRead.Text + "'" :
                    "not specified.")
                    + Environment.NewLine);

                var output = ReadEmployee(
                    checkIDRead.Checked ? Convert.ToInt32(numericIDReadFrom.Value) : Convert.ToInt32(numericIDReadFrom.Minimum),
                    checkIDRead.Checked ? Convert.ToInt32(numericIDReadTo.Value) : Convert.ToInt32(numericIDReadTo.Maximum),
                    textFullNameRead.Text
                    );

                if (output.Count > 0)
                {
                    textOutput.AppendText("Results of SELECT query:" + Environment.NewLine);
                    foreach (var elem in output)
                    {
                        textOutput.AppendText("Object Example, ID = " + elem.ID +
                            ", full name is '" + elem.FullName + "'." + Environment.NewLine);
                    }
                }
                else
	                {
                        textOutput.AppendText("Query has no result to show.");
	                }
            }
            catch (Exception ex)
            {
                textOutput.AppendText("Unknown error has occurred. Details:" + Environment.NewLine + ex.Message);
            }
            finally
            {
                textOutput.AppendText(newMessage);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(numericIDCreate.Value);
            var fullname = textFullNameCreate.Text;
            try
            {
                CreateEmployee(ID, fullname);
                textOutput.AppendText("Element 'Employee' with ID = " + ID + " and Fullname = '" + fullname + "' has been created successfully");
            }
            catch (UpdateException ex)
            {
                textOutput.AppendText("Create error has occurred. Probably your query contains ID that already exists in database.");
            }
            catch (Exception ex)
            {
                textOutput.AppendText("Unknown error has occurred. Details:" + Environment.NewLine + ex.Message);
            }
            finally
            {
                textFullNameCreate.Clear();
                textOutput.AppendText(newMessage);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(numericIDUpdateFrom.Value);
            var newName = textFullNameUpdate.Text;

            try
            {
                var result = UpdateEmployee(ID,newName);
                if (result)
                    textOutput.AppendText("Record of employee with ID = " + ID + " was updated successfully to: ID = " + ID +
                        " Full Name = '" + newName + "'.");
                else
                    textOutput.AppendText("Record of employee with ID = " + ID + " was not found in database.");
            }
            catch (Exception ex)
            {
                textOutput.AppendText("Unknown error has occurred. Details:" + Environment.NewLine + ex.Message);
            }
            finally
            {
                textOutput.AppendText(newMessage);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = (employeesList.SelectedItem as Employee).ID;
            var name = String.Copy((employeesList.SelectedItem as Employee).FullName);
            try
            {
                bool result = DeleteEmployee(ID);
                reconstructList();
                if (result)
                    textOutput.AppendText("Employee '" + name + "' with ID = " + ID + " has been successfully deleted from database.");
                else
                    textOutput.AppendText("Employee '" + name + "' with ID = " + ID + " does not exist.");
                
            }
            catch (Exception ex)
            {
                textOutput.AppendText("Delete error has occurred.");
            }
            finally
            {
                textOutput.AppendText(newMessage);
            }
        }
        #endregion

        
    }
}
