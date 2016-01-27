using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

    This is just a test class with no actual use.
    Later use may come into play

    lol
    fsdfisdjfsdgh
    pickle breath
*/


namespace MasterProject
{
    class Player
    {
        //Constructor for Player class
        public Player(int x, int y)
        {
            locationx = x;
            locationy = y;
        }

        private int locationp;

        public int getLocationP()
        {
            return this.locationp;
        }

        public void setLocationP(int p)
        {
            this.locationp = p;
        }

        //Private location X data member
        private int locationx {
            get{
                return this.locationx;
            }
            set{
                this.locationx = value;
            }
        }

        //private location Y data member
        private int locationy
        {
            get{
                return this.locationy;
            }
            set{
                this.locationy = value;
            }
        }
    }
}
