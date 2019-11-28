using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlAnElevator 
{
   
    public partial class ElevatorControl : Form
    {        bool go_to_Earth = false;                          // changes value and when elevator reaches to the differtent floors or checks where the elevator is.
        bool Go_to_Moon = false;
             bool Earth_floor_arrived = false;                 // helps to put values in database if elevator arrives to earth or ground floor and moon or first floor
             bool Moon_floor_arived = false;                  
             Door da = new Door();                             // object for door class is created
        Lift la = new Lift();                                   // object for lift class is made
             int increment = 0;                                 
             DatabaseCommand dc = new DatabaseCommand();         
        
            

           

        public ElevatorControl()
        {
            InitializeComponent();                                // constructor to initialize variables is called.
                                                                // method Initialize components for different resoures is loaded.
           
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            btn_down.BackColor = Color.Blue;
                 go_to_Earth = true;

                timer_door_close_up.Enabled = true;                     /*timer to close doors of the first floor has been made true 
                                                                       as elevetor moves to the ground floor or ground floor button is pressed  */
            timer_door_open_up.Enabled = false;                      /* timer to open doors of the first floor needs to be closed 
                                                                          because elevator is at ground floor now and emergency btn has not been pressed */  
                 Moon_floor_arived = false;

                 btn_up.Enabled = false;                            // in this case up button and btn 1 are made false
                 btn_1.Enabled = false;
                 btn_emergency.Enabled = false;
            
           
        }

       

        private void timer_door_close_up_Tick(object sender, EventArgs e) // timer to close the door of first floor
        {
            if (door_left_up.Left <=110 && door_right_up.Left >=162)
            {
                da.door_close(door_left_up, door_right_up, door_left_down, door_right_down);//call the method to cose the door of the first floor
               
            }
            else
            {
                automatic_door_close.Enabled = false;         
                increment = 0;

                timer_door_close_up.Enabled = false;             //timer to close door of first floor is disabled
                
                
                dc.insertdata("First Floor doors closed");       //inserts data for 1st floor doors closed in database
                LoadData();                                      // shows database reccord instantly in UI
                btn_close.BackColor = Color.White;
                
                
               if(go_to_Earth==true){
                   automatic_door_close.Enabled = false;
                   increment = 0;

                   display_panel.Image = global::ControlAnElevator.Properties.Resources.down;
                   picture_up.Image = global::ControlAnElevator.Properties.Resources.down;
                   picture_down.Image = global::ControlAnElevator.Properties.Resources.down;
                   timer_lift_down.Enabled = true; //timer to move the elavator to ground floor
                   go_to_Earth = false;
                   btn_close.BackColor = Color.White;

               }

            }

      }

        private void timer_lift_down_Tick(object sender, EventArgs e) //timer to move lift to do
        {
            if (picture_lift.Top <= 352)
            {
                la.lift_down(picture_lift); // calls the method to move the elevator
                btn_emergency.Enabled = false;
               
               
           }
            else
            {
                
                
                timer_lift_down.Enabled = false;
                dc.insertdata("elevetor went down"); // data inserted in databse
                LoadData(); // shows database record in GUI 
                btn_1.Enabled = false;
                btn_G.Enabled = true;
                btn_up.Enabled = false;
               
                
                 timer_door_open_down.Enabled = true;                //Timer to open doors of Earth floor
               
                timer_door_close_down.Enabled = false;               // Timer to close doors of lower floor
                Earth_floor_arrived = true;                         // bool has been made true as lift reaches to the lower floor
           
             
               
                display_panel.Image = global::ControlAnElevator.Properties.Resources.G;

                    picture_up.Image = global::ControlAnElevator.Properties.Resources.G;
                picture_down.Image = global::ControlAnElevator.Properties.Resources.G;
                


            }
        }

        private void timer_door_open_down_Tick(object sender, EventArgs e)// timer that opens the door of ground floor
        {
            increment = 0;
            if (door_left_down.Left >= 61 && door_right_down.Left <= 208)
            {
                da.door_open(door_left_down, door_right_down,door_right_up, door_left_up);
                btn_1.Enabled = true;
                btn_up.Enabled = true;
            }
            else
            {
                automatic_door_close.Enabled = true;
                timer_door_open_down.Enabled = false;
                dc.insertdata("Ground Floor Doors opened ");             // inserts data into the database
                LoadData();                                             // loads and shows data instantly

                btn_up.Enabled = true;
                btn_down.Enabled = true;
                btn_G.Enabled = true;
                btn_emergency.Enabled = true;
                btn_down.BackColor = Color.White;
                btn_G.BackColor = Color.White;
                btn_open.BackColor = Color.White;
                btn_close.BackColor = Color.White;
              

                automatic_door_close.Enabled = true;
            }

        }



        private void btn_up_Click(object sender, EventArgs e)             /* click event for opening door button of first floor*/
        {
            btn_up.BackColor = Color.Green;
                Go_to_Moon = true;
                timer_door_close_down.Enabled = true;       //timer to close ground floor door
                timer_door_open_down.Enabled = false;      
                Earth_floor_arrived = false;

                btn_down.Enabled = false ;
                btn_G.Enabled = false;
                btn_emergency.Enabled = false;

        }

        private void timer_door_close_down_Tick(object sender, EventArgs e)
        {

            if (door_left_down.Left <= 110 && door_right_down.Left >= 162)
            {
                da.door_close(door_left_up, door_right_up, door_left_down, door_right_down);
                                   //  through the object (da), methods (door_close) of class Door is called here!
            }

            else {
                increment = 0;
                automatic_door_close.Enabled = false;
                     timer_door_close_down.Enabled = false;
                     dc.insertdata("Ground Floor Doors Closed");                 //puts record of door closed to the database
                     LoadData();
                     btn_close.BackColor = Color.White;
       
               if(Go_to_Moon==true){
                    display_panel.Image = global::ControlAnElevator.Properties.Resources.up;
                    picture_up.Image = global::ControlAnElevator.Properties.Resources.up;
                    picture_down.Image = global::ControlAnElevator.Properties.Resources.up;
                    timer_lift_up.Enabled = true;                           /* timer set to move the evelator to the first floor
                                                                          within 5 seconds */
                                                      
                    Go_to_Moon = false;
                    
                }
             }
        }

        private void timer_lift_up_Tick(object sender, EventArgs e)
        {
            if (picture_lift.Top >= 51)
            {
                la.lift_up(picture_lift);                     /* calls the method(lift_up) from
                                                                class -Lift.cs to move the elevator through the object (la)*/
                btn_G.Enabled = false;
                btn_emergency.Enabled = false;
                btn_down.Enabled = false;
                
                
            }
            else 
            {
                timer_lift_up.Enabled = false;                              //timer to move the elavator to the first floor
                dc.insertdata(" Elevator went Up");// database record
                LoadData();// shows record to GUI
                timer_door_open_up.Enabled = true;//timer to open door
                timer_door_close_up.Enabled = false;//timer to close door
                Moon_floor_arived = true;
               
               

                display_panel.Image = global::ControlAnElevator.Properties.Resources._1;
                picture_up.Image = global::ControlAnElevator.Properties.Resources._1;
                picture_down.Image = global::ControlAnElevator.Properties.Resources._1;
              
            }
        }

        private void timer_door_open_up_Tick(object sender, EventArgs e)
        {
            if (door_left_up.Left >= 61 && door_right_up.Left <= 208)
            {
               da.door_open(door_left_up, door_right_up, door_left_down, door_right_down);
                /* calls the  methods (door_open) of class Door to open the door
                 through the object (da).
                */        
            }
            else
            {
                automatic_door_close.Enabled = true;
                timer_door_open_up.Enabled = false;                    //timer to open door
                dc.insertdata("First Floor Doors opened"); 
                LoadData();                                           //loads data instantly to UI
                btn_down.Enabled = true;
                btn_G.Enabled = true;
                btn_1.Enabled = true;
                btn_emergency.Enabled = true;
                automatic_door_close.Enabled = true;
                btn_open.BackColor = Color.White;
                btn_1.BackColor = Color.White;
                btn_up.BackColor = Color.White;
                btn_close.BackColor = Color.White;
           }
        }

     

        private void btn_G_Click(object sender, EventArgs e)
        {
            btn_G.BackColor = Color.Blue;
            btn_1.Enabled = false;
            Moon_floor_arived = false;
            go_to_Earth = true;
            timer_door_close_up.Enabled = true;
            timer_door_open_up.Enabled = false;
            btn_up.Enabled = false;

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.Blue;
            
            Go_to_Moon = true;
            Earth_floor_arrived = false;
            timer_door_close_down.Enabled =true;
            timer_door_open_down.Enabled = false;
            btn_down.Enabled = false;
            btn_G.Enabled = false;
        }

       
        private void btn_close_Click(object sender, EventArgs e)
        {
            btn_close.BackColor = Color.Blue;
            if (Earth_floor_arrived == true)
            {
               
                timer_door_close_down.Enabled = true;
                timer_door_open_down.Enabled = false;
            }
            else if (Moon_floor_arived == true)
            {
                
                timer_door_close_up.Enabled = true;
                timer_door_open_up.Enabled = false;
            }

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            btn_open.BackColor = Color.Blue;
              if (Earth_floor_arrived==true)
            {
               
                timer_door_open_down.Enabled = true;
                timer_door_close_down.Enabled = false;
            }
            else if (Moon_floor_arived==true)
            {

                timer_door_close_up.Enabled = false;
                timer_door_open_up.Enabled = true;
            }

        }

        private void btn_emergency_Click(object sender, EventArgs e)
        {
            dc.insertdata("Emergency Exit button is pressed !!");
            LoadData();
            display_panel.Image = global::ControlAnElevator.Properties.Resources.alarmbellbutton;
            timer_lift_down.Enabled = false;
            timer_lift_up.Enabled = false;
            timer_door_open_down.Enabled = true;
            timer_door_open_up.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void door_left_up_Click(object sender, EventArgs e)
        {

        }

        private void ElevatorControl_Load(object sender, EventArgs e)
        {
            GlobalConnection.DbConnection();                               // database connection is established
            
        }
        public void LoadData()
        {
            try
            {
                DatabaseCommand dc = new DatabaseCommand();
                DataTable dt = dc.ViewData();
                dataGridView1.DataSource = dt;                    // to import data in grid view format
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ControlAnElevator !");
            }

        }

        private void clrLog_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;                         // clears the data of datagrid view
            dc.remove();                                 // removes record from database by running method remove through object dc.
           
            
           

        }

        private void picture_down_Click(object sender, EventArgs e)
        {

        }
        private void automatic_door_close_Tick(object sender, EventArgs e) //timer to close door automatically
        {
            increment++;
            if (increment>=240 && Earth_floor_arrived==true)
            {

                timer_door_close_down.Enabled = true;
                
               
            }
            else if (increment >= 240 && Moon_floor_arived == true)
            {

                timer_door_close_up.Enabled = true;
                

            }
        }

        private void door_right_up_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void first_floor_Click(object sender, EventArgs e)
        {

        }
    }
    }

 