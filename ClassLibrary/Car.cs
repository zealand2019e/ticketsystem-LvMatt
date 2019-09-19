using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public  class Car : Ticket
    {
        public  string LicensePlate;
        public DateTime Date;
        

       

        /// <summary>
        /// This method returns double price
        /// </summary>
        /// 
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// This method returns string VehicleType
        /// </summary>
        public string VehicleType()
        {
            return "Car";
        }

        // int LPLength = LicensePlate.Length;
      

    }
}
