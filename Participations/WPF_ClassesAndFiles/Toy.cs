using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ClassesAndFiles
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        private string Aisle;


        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Toy()
        {
            Manufacturer = string.Empty;
            Name         = string.Empty;
            Price        = 0;
            Image        = string.Empty;
            Aisle        = string.Empty;
        }


        public string GetAisle()
        {
            Aisle = Manufacturer.ToUpper()[0] + Price.ToString().Replace(",","").Replace(".","").Replace("$","");

            return Aisle;
        }


        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }
    }
}
