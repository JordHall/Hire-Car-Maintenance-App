using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HireCarMaintenanceApp
{
    public partial class frmAddNewCompany : Form
    {
        //Form constructor
        public frmAddNewCompany()
        {
            InitializeComponent();
        }

        //Procedure handles saving input data into a new company object contained in the main form's ArrayList
        public void saveNewCompany(string id, string name, string address, string postcode, string numCars)
        {
            try
            {
                frmMain.companies.Add(new Company(Convert.ToInt32(id), name, address, postcode, Convert.ToInt32(numCars)));
                MessageBox.Show(string.Format("Company {0} has saved successfully", name));
            }
            catch(Exception e)
            {
                MessageBox.Show("One or more fields do not contain valid data.\n\n" + e.Message);
            }
        }

        //Procedure handling reseting input fields to default
        public void reset()
        {
            txtAddress.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtNumOfCars.Text = "0";
            txtPostcode.Text = "";
        }

        //Procedure handles closing this form and returning to the main form
        public void exitForm()
        {
            this.Close();
            frmMain.mainForm.Show();
            frmMain.mainForm.displayData(frmMain.companies.Count - 1);
        }

        //Save button click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveNewCompany(txtId.Text, txtName.Text, txtAddress.Text, txtPostcode.Text, txtNumOfCars.Text);
        }

        //Reset button click event
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        //Exit button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitForm();
        }
    }
}
