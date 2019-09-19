using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public  class MC : Ticket
    {
        public static string Licenseplate;
        public DateTime date;



        /// <summary>
        /// This method returns double price
        /// </summary>

        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// This method returns string VehicleType
        /// </summary>
        public string Vehicle()
        {
            return "MC";
        }

        public  string LicenseLength()
        {
            if (Licenseplate.Length > 7)
            {
                throw new IndexOutOfRangeException();
            }
            return "AA";
        }
            
        }


    }
