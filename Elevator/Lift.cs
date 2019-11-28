using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ControlAnElevator
{
    class Lift
    {
        public void lift_down(PictureBox picture_lift) 
        {
            if (picture_lift.Top <= 352)
            {
                picture_lift.Top += 1; // elevator goes down
            }
         }

         public void lift_up(PictureBox picture_lift)
         {
            if (picture_lift.Top >= 51)
            {
                picture_lift.Top -= 1; //elevator goes up
            }
         }

       
    }
}
