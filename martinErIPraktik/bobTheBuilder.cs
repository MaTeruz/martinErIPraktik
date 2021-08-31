using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martinErIPraktik
{
    public class square
    {
        private float side;
        public square(float side) {this.side = side;}
        public square() { }
        public float Side 
        {
            get { return this.side; }
            set { this.side = value; }
        }
        public float Perimitor()
        {
            return 4 * side;
        }
        public float Area()
        {
            return side * side;
        }        
    }    
}
