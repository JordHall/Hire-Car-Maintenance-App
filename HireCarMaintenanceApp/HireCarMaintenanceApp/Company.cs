using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace HireCarMaintenanceApp
{
    public class Company
    {
        //Class variables declared
        private int idNumber;
        private string name;
        private string address;
        private string postcode;
        private int numOfCars;
        //ArrayList for car objects declared
        private ArrayList cars = new ArrayList();

        //Default and other constructors declared
        public Company()
        {

        }

        //Constructor with all data entry without ArrayList
        public Company(int id, string inputName, string inputAddress, string inputPostcode, int carNum)
        {
            IDNumber = id;
            Name = inputName;
            Address = inputAddress;
            Postcode = inputPostcode;
            NumOfCars = carNum;
        }

        //Constructor with all data entry and ArrayList
        public Company(int id, string inputName, string inputAddress, string inputPostcode, int carNum, ArrayList carList)
        {
            IDNumber = id;
            Name = inputName;
            Address = inputAddress;
            Postcode = inputPostcode;
            NumOfCars = carNum;
            Cars = carList;
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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                try
                {
                    name = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter a Company Name which is a string value");
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                try
                {
                    address = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter a valid address which is a string value");
                }
            }
        }

        public string Postcode
        {
            get
            {
                return postcode;
            }
            set
            {
                try
                {
                    postcode = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter a valid postcode which is a string value");
                }
            }
        }

        public int NumOfCars
        {
            get
            {
                return numOfCars;
            }
            set
            {
                try
                {
                    numOfCars = value;
                }
                catch
                {
                    MessageBox.Show("Error: Please enter the number of cars which is a valid integer number");
                }
            }
        }

        public ArrayList Cars
        {
            get
            {
                return cars;
            }
            set
            {
                cars.Add(value);
            }
        }

        //
        public void removeCar()
        {
            //Remove car object when selected from list box
        }

        //Method that outputs all details of this object, for use in list boxes
        public string outputDetails()
        {
            return string.Format("{0} - ID:  {1} - Located at {2}, {3} - Number of cars: {4}", Name, IDNumber, Address, Postcode, NumOfCars);
        }
    }
}
