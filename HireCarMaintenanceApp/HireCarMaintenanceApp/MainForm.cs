using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace HireCarMaintenanceApp
{
    public partial class frmMain : Form
    {
        //Public static objects declared to be accessed through various other forms, including the main ArrayList and this form instance
        public static ArrayList companies = new ArrayList();
        public static frmMain mainForm = null;

        //Form constructor
        public frmMain()
        {
            InitializeComponent();
            mainForm = this;
        }

        //Procedure that handles importing data from a file and storing them as Objects in ArrayLists
        public void importFile()
        {
            try
            {
                lstCompany.Items.Clear();
                lstCar.Items.Clear();
                StreamReader dataFile = new StreamReader("input.txt");
                string firstLine;
                //While loop reads through file until end
                while ((firstLine = dataFile.ReadLine()) != null)
                {
                    int companyId = Convert.ToInt32(firstLine);
                    string companyName = dataFile.ReadLine();
                    string address = dataFile.ReadLine();
                    string postcode = dataFile.ReadLine();
                    int numOfCars = Convert.ToInt32(dataFile.ReadLine());
                    Company newCompany = new Company(companyId, companyName, address, postcode, numOfCars);
                    companies.Add(newCompany);
                    //For loop reads every car based on the number of cars declared in file
                    for (int i = 0; i < numOfCars; i++)
                    {
                        int carId = Convert.ToInt32(dataFile.ReadLine());
                        string make = dataFile.ReadLine();
                        string registration = dataFile.ReadLine();
                        string fuel = dataFile.ReadLine();
                        string date = dataFile.ReadLine();
                        string comments = dataFile.ReadLine();
                        newCompany.Cars.Add(new Car(carId, make, registration, fuel, date, comments));
                    }
                }
                //Calls display data procedure in order to make data visible to the user
                displayData(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error while importing data from the file\n\n" + e.Message);
            }
        }

        //Procedure handles saving objects from ArrayLists into the text file
        public void exportFile()
        {
            try
            {
                StreamWriter dataFile = new StreamWriter("output.txt");
                foreach (Company company in companies)
                {
                    dataFile.WriteLine(company.IDNumber);
                    dataFile.WriteLine(company.Name);
                    dataFile.WriteLine(company.Address);
                    dataFile.WriteLine(company.Postcode);
                    dataFile.WriteLine(company.NumOfCars);
                    foreach (Car car in company.Cars)
                    {
                        dataFile.WriteLine(car.IDNumber);
                        dataFile.WriteLine(car.MakeModel);
                        dataFile.WriteLine(car.Registration);
                        dataFile.WriteLine(car.FuelType);
                        dataFile.WriteLine(car.LastServiceDate);
                        dataFile.WriteLine(car.Comments);
                    }
                }
                dataFile.Close();
                MessageBox.Show("File saved successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: The file did not save successfully" + e.Message);
            }
        }

        //Procedure that handles putting all company objects into a listbox
        public void displayData(int index)
        {
            try
            {
                lstCompany.Items.Clear();
                foreach (Company comp in companies)
                {
                    lstCompany.Items.Add(comp.outputDetails());
                }
                if (lstCompany.Items.Count > 0)
                {
                    lstCompany.SelectedIndex = index;
                    displayCars();
                }
                else return;
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error while displaying company data\n\n" + e.Message);
            }
        }

        //Procedure handles putting the selected companies car objects into a listbox
        public void displayCars()
        {
            try
            {
                lstCar.Items.Clear();
                int index = lstCompany.SelectedIndex;
                Company company = (Company)companies[index];
                if (company.NumOfCars > 0)
                {
                    foreach (Car car in company.Cars)
                    {
                        lstCar.Items.Add(car.outputDetails());
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error while displaying car data\n\n" + e.Message);
            }
        }

        //Procedure handles creating a new instance of Add New Company form
        public void addNewCompany()
        {
            frmAddNewCompany newCompany = new frmAddNewCompany();
            mainForm.Hide();
            newCompany.Show();
        }

        //Procedure handles creating a new instance of Edit New Company form
        public void editCompany()
        {
            try
            {
                int index = lstCompany.SelectedIndex;
                Company company = (Company)companies[index];
                frmEditCompany editCompany = new frmEditCompany(company, index);
                mainForm.Hide();
                editCompany.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Please select a company first.\n\n" + e.Message);
            }
        }

        //Procedure handles creating a new instance of Create New Car form
        public void addNewCar()
        {
            try
            {
                int index = lstCompany.SelectedIndex;
                Company company = (Company)companies[index];
                frmAddNewCar addNewCar = new frmAddNewCar(company, index);
                mainForm.Hide();
                addNewCar.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Please select a company first.\n\n" + e.Message);
            }
        }

        //Procedure handles creation of Edit Car form instance
        public void editCar()
        {
            try
            {
                int indexComp = lstCompany.SelectedIndex;
                int indexCar = lstCar.SelectedIndex;
                Company company = (Company)companies[indexComp];
                Car car = (Car)company.Cars[indexCar];
                frmEditCar editCar = new frmEditCar(company, car, indexComp);
                mainForm.Hide();
                editCar.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Please select a company and car first.\n\n" + e.Message);
            }
        }

        //Procedure handles the removal of a car from a selected company
        public void deleteCar()
        {
            try
            {
                int indexComp = lstCompany.SelectedIndex;
                int indexCar = lstCar.SelectedIndex;
                Company company = (Company)companies[indexComp];
                company.Cars.RemoveAt(indexCar);
                company.NumOfCars--;
                displayData(indexComp);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Please select a company and car first.\n\n" + e.Message);
            }
        }

        //Procedure handles searching through company list and selecting them
        public void searchCompany(string search)
        {
            try
            {
                //Searches through the list for items beginning with input string
                if (search != string.Empty)
                {
                    int index = lstCompany.FindString(search);
                    if (index >= 0)
                    {
                        lstCompany.SetSelected(index, true);
                    }
                    else
                    {
                        MessageBox.Show("Company not found.");
                        txtSearchComp.Text = "";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Company not found. Please import data to search first.\n\n" + e.Message);
                txtSearchComp.Text = "";
            }
        }

        //Procedure handles search through car list and selecting them
        public void searchCar(string search)
        {
            try
            {
                //Searches through the list for items beginning with input string
                if (search != string.Empty)
                {
                    int index = lstCar.FindString(search);
                    if (index >= 0)
                    {
                        lstCar.SetSelected(index, true);
                    }
                    else
                    {
                        MessageBox.Show("Car not found.");
                        txtSearchCar.Text = "";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Car not found. Please import data to search first.\n\n" + e.Message);
                txtSearchCar.Text = "";
            }
        }

        //Procedure to close this application
        public void exitProgram()
        {
            exportFile();
            Close();
        }

        //Exit button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgram();
        }

        //Load file button click event
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            importFile();
        }

        //User selects new company event
        private void lstCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayCars();
        }

        //Add company button click event
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            addNewCompany();
        }

        //Edit company button click event
        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            editCompany();
        }

        //Add car button click event
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            addNewCar();
        }

        //Edit car button click event
        private void btnEditCar_Click(object sender, EventArgs e)
        {
            editCar();
        }

        //Delete car button click event
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            deleteCar();
        }

        //Search compnaies button click event
        private void btnSearchComp_Click(object sender, EventArgs e)
        {
            searchCompany(txtSearchComp.Text);
        }

        //Search cars button click event
        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            searchCar(txtSearchCar.Text);
        }
    }
}
