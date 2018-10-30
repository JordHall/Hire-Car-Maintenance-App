using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HireCarMaintenanceApp
{
    public class Car
    {
        //Class variables declared
        private int idNumber;
        private string makeModel;
        private string registration;
        private string fuelType;
        private string lastServiceDate;
        private string comments;

        //Default and other constructors declared
        public Car()
        {

        }

        //Main constructor with all data entry
        public Car(int id, string make, string reg, string fuel, string lastService, string comm)
        {
            IDNumber = id;
            MakeModel = make;
            Registration = reg;
            FuelType = fuel;
            LastServiceDate = lastService;
            Comments = comm;
        }

        //Class properties declared - allow data validation and security
        public int IDNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                try
                {
                    idNumber = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter a ID number which is valid integer number");
                }
            }
        }

        public string MakeModel
        {
            get
            {
                return makeModel;
            }
            set
            {
                try
                {
                    makeModel = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter a Make and Model that is a string value");
                }
            }
        }

        public string Registration
        {
            get
            {
                return registration;
            }
            set
            {
                try
                {
                    registration = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter a registration number that is a string value");
                }
            }
        }

        public string FuelType
        {
            get
            {
                return fuelType;
            }
            set
            {
                try
                {
                    fuelType = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter a fuel type that is a string value, either Petrol or Diesel");
                }
            }
        }

        public string LastServiceDate
        {
            get
            {
                return lastServiceDate;
            }
            set
            {
                try
                {
                    lastServiceDate = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter a service date that is a string value");
                }
            }
        }

        public string Comments
        {
            get
            {
                return comments;
            }
            set
            {
                try
                {
                    comments = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter comments that are a string value");
                }
            }
        }

        //Method that outputs all details of this object, for use in list boxes
        public string outputDetails()
        {
            return string.Format("{0} - ID: {1} - Registration: {2} - Fuel: {3} - Date of last service: {4} - Comments: {5}", MakeModel, IDNumber, Registration, FuelType, LastServiceDate, Comments);
        }
    }
}
