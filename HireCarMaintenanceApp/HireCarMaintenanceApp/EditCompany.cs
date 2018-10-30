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
    public partial class frmEditCompany : Form
    {
        //Company this form is dealing with declared at the beginning
        Company company;
        int index;

        //Form constructor
        public frmEditCompany(Company selectedCompany, int selectedIndex)
        {
            InitializeComponent();
            company = selectedCompany;
            index = selectedIndex;
            reset();
        }

        //Procedure that takes parameters and attempts to save the changes to the attributes
        public void saveCompany(string id, string name, string address, string postcode, string numCars)
        {
            try
            {
                company.IDNumber = Convert.ToInt32(id);
                company.Name = name;
                company.Address = address;
                company.Postcode = postcode;
                company.NumOfCars = Convert.ToInt32(numCars);
                MessageBox.Show(string.Format("Company {0} has been edited and saved successfully", name));
            }
            catch (Exception e)
            {
                MessageBox.Show("One or more fields do not contain valid data.\n\n" + e.Message);
            }
        }

        //Procedure handling reseting input fields to default
        public void reset()
        {
            txtAddress.Text = company.Address;
            txtId.Text = company.IDNumber.ToString();
            txtName.Text = company.Name;
            txtNumOfCars.Text = company.NumOfCars.ToString();
            txtPostcode.Text = company.Postcode;
        }

        //Procedure handles closing this form and returning to the main form
        public void exitForm()
        {
            this.Close();
            frmMain.mainForm.Show();
            frmMain.mainForm.displayData(index);
        }

        //Exit button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitForm();
        }

        //Save button click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveCompany(txtId.Text, txtName.Text, txtAddress.Text, txtPostcode.Text, txtNumOfCars.Text);
        }

        //Reset button click event
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
