using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrog
{
    class Frog
    {
        //MODEL part of MVC
        //This part is where the more complex part of the application sits
        //direct access to this is not possible and is done via CONTROL or VIEW

        //member variables
        int size = 0;

        //setter method to increase frog growth by 1 (max 1000)
        public void grow()
        {
            size++;
            if (size > 1000)
            {
                size = 1000;
            }
        }

        //setter method to shrink frog growth by 1 (min 0)
        public void shrink()
        {
            size--;
            if (size < 0)
            {
                size = 0;
            }
        }

        //getter method, returns the size
        public int getSize()
        {
            return size;
        }
    }
}
