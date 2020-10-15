using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrog
{
    class FrogController
    {
        //CONTROL part of MVC
        //This part is controls access to the MODEL, the user will be able to
        //interact with the controller, and the controller will pass the required data on
        //to the MODEL

        //member variables
        Frog frog = new Frog();

        //methods call their MODEL counterparts
        public void growFrog()
        {
            frog.grow();
        }

        public void shrinkFrog()
        {
            frog.shrink();
        }

        public int getFrogSize()
        {
            return frog.getSize();
        }


    }
}
