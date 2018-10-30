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
    public partial class frmAddNewCar : Form
    {
        //Company this form is dealing with declared at the beginning
        Company company;
        int index;

        //Form constructor
        public frmAddNewCar(Company selectedCompany, int selectedIndex)
        {
            InitializeComponent();
            company = selectedCompany;
            index = selectedIndex;
        }

        //Procedure handles taking parameters and attempting to save them as a new car object, into the companies car ArrayList
        public void saveNewCar(string id, string makeModel, string reg, string fuel, string service, string comments)
        {
            try
            {
                company.Cars.Add(new Car(Convert.ToInt32(id), makeModel, reg, fuel, service, comments));
                company.NumOfCars++;
                MessageBox.Show(string.Format("Car {0} has saved successfully", makeModel));
            }
            catch (Exception e)
            {
                MessageBox.Show("One or more fields do not contain valid data.\n\n" + e.Message);
            }
        }

        //Procedure handling reseting input fields to default
        public void reset()
        {
            txtFuelType.Text = "";
            txtId.Text = "";
            txtMakeModel.Text = "";
            txtRegistration.Text = "";
            txtServiceDate.Text = "";
            txtComments.Text = "";
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
            saveNewCar(txtId.Text, txtMakeModel.Text, txtRegistration.Text, txtFuelType.Text, txtServiceDate.Text, txtComments.Text);
        }

        //Reset button click event
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
