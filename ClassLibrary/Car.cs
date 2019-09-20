using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Ticket
    {
        public  string LicensePlate;
        string Days = DateTime.Now.ToString("dddd");




        /// <summary>
        /// This method returns double price it returns discount if your brobizz is true
        /// </summary>
        /// 

  

        public  double WeekendDiscount()
        {
            if (Days.Contains("Saturday" + "Sunday"))
            {
                return 20;
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// This method returns string VehicleType
        /// </summary>
        public string VehicleType()
        {
            return "Car";
        }

        public override double Price()
        {
            if (brobizz = true)
            {
                return (240 / 100) * 105;
            }
            else
            {
                return 240;

            }
        }

        // int LPLength = LicensePlate.Length;


    }
}
