using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsNeutered { get; set; }
        public string Description { get; set; }
        public Shelter Shelter { get; set; }
    }
}
