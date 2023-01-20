using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Model
{
    public class CarModel
    {
        
        public string make { get; set; }
        public string model { get; set; }
        public string colour { get; set; }
        public decimal price { get; set; }
        public bool available { get; set; }
    }
}
