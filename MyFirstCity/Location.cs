using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCity
{
    class Location
    {
        #region Properties
        public int Zipcode { get; set; }
        public int Milepost { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        #endregion
        #region Methods
        public void AddLocation (int zip, int milepost, string city, string state)
        {
            this.Zipcode = zip; this.Milepost = milepost; this.City = city; State = state;
        }
        #endregion
    }
    
} 
