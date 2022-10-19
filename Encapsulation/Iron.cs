using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Iron
    {
        public string Brand { get; set; }
        public int Temperature { get; set; }
       
        private string _color;

        public string Color
        {
            get { return _color; }
            set
            {
                if (value == "Blue")
                    _color = value;
                else
                    _color = "Not specified";
            }
        }
    }
}
