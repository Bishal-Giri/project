namespace ControlAnElevator
{
    partial class ElevatorControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorControl));
            this.timer_door_open_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_down = new System.Windows.Forms.Timer(this.components);
            this.timer_lift_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_down = new System.Windows.Forms.Timer(this.components);
            this.timer_lift_up = new System.Windows.Forms.Timer(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.record_date = new System.Windows.Forms.Label();
            this.clrLog = new System.Windows.Forms.Button();
            this.automatic_door_close = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picture_down = new System.Windows.Forms.PictureBox();
            this.picture_up = new System.Windows.Forms.PictureBox();
            this.display_panel = new System.Windows.Forms.PictureBox();
            this.btn_emergency = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.door_left_up = new System.Windows.Forms.PictureBox();
            this.door_left_down = new System.Windows.Forms.PictureBox();
            this.door_right_up = new System.Windows.Forms.PictureBox();
            this.door_right_down = new System.Windows.Forms.PictureBox();
            this.picture_lift = new System.Windows.Forms.PictureBox();
            this.first_floor = new System.Windows.Forms.PictureBox();
            this.ground_floor = new System.Windows.Forms.PictureBox();
            this.controlpanel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_emergency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlpanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_door_open_up
            // 
            this.timer_door_open_up.Interval = 5;
            this.timer_door_open_up.Tick += new System.EventHandler(this.timer_door_open_up_Tick);
            // 
            // timer_door_close_up
            // 
            this.timer_door_close_up.Interval = 5;
            this.timer_door_close_up.Tick += new System.EventHandler(this.timer_door_close_up_Tick);
            // 
            // timer_door_open_down
            // 
            this.timer_door_open_down.Interval = 5;
            this.timer_door_open_down.Tick += new System.EventHandler(this.timer_door_open_down_Tick);
            // 
            // timer_lift_down
            // 
            this.timer_lift_down.Interval = 15;
            this.timer_lift_down.Tick += new System.EventHandler(this.timer_lift_down_Tick);
            // 
            // timer_door_close_down
            // 
            this.timer_door_close_down.Interval = 5;
            this.timer_door_close_down.Tick += new System.EventHandler(this.timer_door_close_down_Tick);
            // 
            // timer_lift_up
            // 
            this.timer_lift_up.Interval = 15;
            this.timer_lift_up.Tick += new System.EventHandler(this.timer_lift_up_Tick);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            // 
            // record_date
            // 
            resources.ApplyResources(this.record_date, "record_date");
            this.record_date.ForeColor = System.Drawing.SystemColors.Desktop;
            this.record_date.Name = "record_date";
            this.record_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // clrLog
            // 
            resources.ApplyResources(this.clrLog, "clrLog");
            this.clrLog.Name = "clrLog";
            this.clrLog.UseVisualStyleBackColor = true;
            this.clrLog.Click += new System.EventHandler(this.clrLog_Click);
            // 
            // automatic_door_close
            // 
            this.automatic_door_close.Interval = 5;
            this.automatic_door_close.Tick += new System.EventHandler(this.automatic_door_close_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlAnElevator.Properties.Resources.elevatortothemoon_796x417__3_1;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // picture_down
            // 
            this.picture_down.Image = global::ControlAnElevator.Properties.Resources._1;
            resources.ApplyResources(this.picture_down, "picture_down");
            this.picture_down.Name = "picture_down";
            this.picture_down.TabStop = false;
            this.picture_down.Click += new System.EventHandler(this.picture_down_Click);
            // 
            // picture_up
            // 
            resources.ApplyResources(this.picture_up, "picture_up");
            this.picture_up.Name = "picture_up";
            this.picture_up.TabStop = false;
            // 
            // display_panel
            // 
            this.display_panel.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.display_panel, "display_panel");
            this.display_panel.Image = global::ControlAnElevator.Properties.Resources.black;
            this.display_panel.Name = "display_panel";
            this.display_panel.TabStop = false;
            // 
            // btn_emergency
            // 
            resources.ApplyResources(this.btn_emergency, "btn_emergency");
            this.btn_emergency.Name = "btn_emergency";
            this.btn_emergency.TabStop = false;
            this.btn_emergency.Click += new System.EventHandler(this.btn_emergency_Click);
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_open
            // 
            resources.ApplyResources(this.btn_open, "btn_open");
            this.btn_open.Name = "btn_open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_G
            // 
            resources.ApplyResources(this.btn_G, "btn_G");
            this.btn_G.Name = "btn_G";
            this.btn_G.UseVisualStyleBackColor = true;
            this.btn_G.Click += new System.EventHandler(this.btn_G_Click);
            // 
            // btn_1
            // 
            resources.ApplyResources(this.btn_1, "btn_1");
            this.btn_1.Name = "btn_1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_down
            // 
            resources.ApplyResources(this.btn_down, "btn_down");
            this.btn_down.Name = "btn_down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            resources.ApplyResources(this.btn_up, "btn_up");
            this.btn_up.Name = "btn_up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // door_left_up
            // 
            resources.ApplyResources(this.door_left_up, "door_left_up");
            this.door_left_up.Name = "door_left_up";
            this.door_left_up.TabStop = false;
            this.door_left_up.Click += new System.EventHandler(this.door_left_up_Click);
            // 
            // door_left_down
            // 
            resources.ApplyResources(this.door_left_down, "door_left_down");
            this.door_left_down.Name = "door_left_down";
            this.door_left_down.TabStop = false;
            // 
            // door_right_up
            // 
            resources.ApplyResources(this.door_right_up, "door_right_up");
            this.door_right_up.Name = "door_right_up";
            this.door_right_up.TabStop = false;
            this.door_right_up.Click += new System.EventHandler(this.door_right_up_Click);
            // 
            // door_right_down
            // 
            resources.ApplyResources(this.door_right_down, "door_right_down");
            this.door_right_down.Name = "door_right_down";
            this.door_right_down.TabStop = false;
            // 
            // picture_lift
            // 
            resources.ApplyResources(this.picture_lift, "picture_lift");
            this.picture_lift.Name = "picture_lift";
            this.picture_lift.TabStop = false;
            // 
            // first_floor
            // 
            this.first_floor.Image = global::ControlAnElevator.Properties.Resources.First_Floor;
            resources.ApplyResources(this.first_floor, "first_floor");
            this.first_floor.Name = "first_floor";
            this.first_floor.TabStop = false;
            this.first_floor.Click += new System.EventHandler(this.first_floor_Click);
            // 
            // ground_floor
            // 
            this.ground_floor.Image = global::ControlAnElevator.Properties.Resources.Ground_Floor11;
            resources.ApplyResources(this.ground_floor, "ground_floor");
            this.ground_floor.Name = "ground_floor";
            this.ground_floor.TabStop = false;
            // 
            // controlpanel
            // 
            resources.ApplyResources(this.controlpanel, "controlpanel");
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlAnElevator.Properties.Resources.elevatorGap;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ElevatorControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clrLog);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.record_date);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.picture_down);
            this.Controls.Add(this.picture_up);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.btn_emergency);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.door_left_up);
            this.Controls.Add(this.door_left_down);
            this.Controls.Add(this.door_right_up);
            this.Controls.Add(this.door_right_down);
            this.Controls.Add(this.picture_lift);
            this.Controls.Add(this.first_floor);
            this.Controls.Add(this.ground_floor);
            this.Controls.Add(this.controlpanel);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "ElevatorControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ElevatorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_emergency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlpanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground_floor;
        private System.Windows.Forms.PictureBox first_floor;
        private System.Windows.Forms.PictureBox picture_lift;
        private System.Windows.Forms.PictureBox controlpanel;
        public System.Windows.Forms.Timer timer_door_open_up;
        public System.Windows.Forms.PictureBox door_left_up;
        public System.Windows.Forms.Timer timer_door_close_up;
        public System.Windows.Forms.Timer timer_door_open_down;
        public System.Windows.Forms.Timer timer_lift_down;
        public System.Windows.Forms.Timer timer_door_close_down;
        public System.Windows.Forms.PictureBox door_right_down;
        public System.Windows.Forms.PictureBox door_right_up;
        public System.Windows.Forms.PictureBox door_left_down;
        public System.Windows.Forms.Button btn_up;
        public System.Windows.Forms.Button btn_down;
        public System.Windows.Forms.Button btn_1;
        public System.Windows.Forms.Button btn_G;
        public System.Windows.Forms.Button btn_open;
        public System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox btn_emergency;
        private System.Windows.Forms.PictureBox display_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picture_up;
        private System.Windows.Forms.PictureBox picture_down;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Timer timer_lift_up;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label record_date;
        private System.Windows.Forms.Button clrLog;
        private System.Windows.Forms.Timer automatic_door_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

