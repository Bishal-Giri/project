using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace ControlAnElevator
{
    class Door
    {
        public void door_close(PictureBox door_left_up, PictureBox door_right_up,
            PictureBox door_left_down, PictureBox door_right_down)
        {
            if (door_left_up.Left <= 110 && door_right_up.Left >= 162)
            {
                door_left_up.Left += 1; //shifts door to right with 1 increment
                door_right_up.Left -= 1;// shifts door to left with 1 decrement

            }

            else if (door_left_down.Left <= 110 && door_right_down.Left >= 162)
            {
                door_left_down.Left += 1; //shifts door to right with 1 increment
                door_right_down.Left -= 1;// shifts door to left with 1 decrement
            }

            
        }

        public void door_open(PictureBox door_left_up, PictureBox door_right_up, 
            PictureBox door_left_down, PictureBox door_right_down)
        {
            if (door_left_up.Left >= 61 && door_right_up.Left <= 208)
            {
                door_left_up.Left -= 1; 
                door_right_up.Left += 1;
            }
            else if (door_left_down.Left >= 61 && door_right_down.Left <= 208)
            {
                door_left_down.Left -= 1; 
                door_right_down.Left += 1; 
            }
        }



   
    
    }
}
