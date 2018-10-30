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
    public partial class frmEditCar : Form
    {
        //Company and cars this form is dealing with declared at the beginning
        Company company;
        Car car;
        int indexComp;

        //Form constructor
        public frmEditCar(Company selectedCompany, Car selectedCar, int selectedIndexComp)
        {
            InitializeComponent();
            company = selectedCompany;
            car = selectedCar;
            indexComp = selectedIndexComp;
            reset();
        }

        //Procedure that takes parameters and attempts to save the changes to the attributes
        public void saveCar(string id, string comments, string fuel, string makeModel, string reg, string date)
        {
            try
            {
                car.Comments = comments;
                car.FuelType = fuel;
                car.IDNumber = Convert.ToInt32(id);
                car.LastServiceDate = date;
                car.MakeModel = makeModel;
                car.Registration = reg;
                MessageBox.Show(string.Format("Car {0} has been edited and saved successfully", makeModel));
            }
            catch (Exception e)
            {
                MessageBox.Show("One or more fields do not contain valid data.\n\n" + e.Message);
            }
        }

        //Procedure handling reseting input fields to default
        public void reset()
        {
            txtId.Text = car.IDNumber.ToString();
            txtComments.Text = car.Comments;
            txtFuelType.Text = car.FuelType;
            txtMakeModel.Text = car.MakeModel;
            txtRegistration.Text = car.Registration;
            txtServiceDate.Text = car.LastServiceDate;
        }

        //Procedure handles closing this form and returning to the main form
        public void exitForm()
        {
            this.Close();
            frmMain.mainForm.Show();
            frmMain.mainForm.displayData(indexComp);
        }

        //Exit button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitForm();
        }

        //Save button click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveCar(txtId.Text, txtComments.Text, txtFuelType.Text, txtMakeModel.Text, txtRegistration.Text, txtServiceDate.Text);
        }

        //Reset button click event
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
