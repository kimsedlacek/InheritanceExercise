using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string Color { get; set; }
        public string Eats {  get; set; }
        public bool LikesHumans {  get; set; }
        public bool HasTeeth {  get; set; }

    }
}
