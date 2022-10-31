namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxElevator = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxDoorDownLeft = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timerOpen = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxDoorDownRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoorLeftUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoorRightUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorDownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorLeftUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorRightUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxElevator
            // 
            this.pictureBoxElevator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxElevator.Image")));
            this.pictureBoxElevator.Location = new System.Drawing.Point(350, 450);
            this.pictureBoxElevator.Name = "pictureBoxElevator";
            this.pictureBoxElevator.Size = new System.Drawing.Size(250, 330);
            this.pictureBoxElevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxElevator.TabIndex = 1;
            this.pictureBoxElevator.TabStop = false;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(889, 487);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(94, 29);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(889, 536);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(94, 29);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // timerUp
            // 
            this.timerUp.Interval = 50;
            this.timerUp.Tick += new System.EventHandler(this.timerUp_Tick);
            // 
            // timerDown
            // 
            this.timerDown.Interval = 50;
            this.timerDown.Tick += new System.EventHandler(this.timerDown_Tick);
            // 
            // pictureBoxDoorDownLeft
            // 
            this.pictureBoxDoorDownLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoorDownLeft.Image")));
            this.pictureBoxDoorDownLeft.Location = new System.Drawing.Point(350, 450);
            this.pictureBoxDoorDownLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxDoorDownLeft.Name = "pictureBoxDoorDownLeft";
            this.pictureBoxDoorDownLeft.Size = new System.Drawing.Size(125, 330);
            this.pictureBoxDoorDownLeft.TabIndex = 5;
            this.pictureBoxDoorDownLeft.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(889, 588);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(889, 641);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerOpen
            // 
            this.timerOpen.Interval = 50;
            this.timerOpen.Tick += new System.EventHandler(this.timerOpen_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 50;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // pictureBoxDoorDownRight
            // 
            this.pictureBoxDoorDownRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoorDownRight.Image")));
            this.pictureBoxDoorDownRight.Location = new System.Drawing.Point(475, 450);
            this.pictureBoxDoorDownRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxDoorDownRight.Name = "pictureBoxDoorDownRight";
            this.pictureBoxDoorDownRight.Size = new System.Drawing.Size(125, 330);
            this.pictureBoxDoorDownRight.TabIndex = 8;
            this.pictureBoxDoorDownRight.TabStop = false;
            // 
            // pictureBoxDoorLeftUp
            // 
            this.pictureBoxDoorLeftUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoorLeftUp.Image")));
            this.pictureBoxDoorLeftUp.Location = new System.Drawing.Point(350, 100);
            this.pictureBoxDoorLeftUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxDoorLeftUp.Name = "pictureBoxDoorLeftUp";
            this.pictureBoxDoorLeftUp.Size = new System.Drawing.Size(125, 330);
            this.pictureBoxDoorLeftUp.TabIndex = 9;
            this.pictureBoxDoorLeftUp.TabStop = false;
            // 
            // pictureBoxDoorRightUp
            // 
            this.pictureBoxDoorRightUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoorRightUp.Image")));
            this.pictureBoxDoorRightUp.Location = new System.Drawing.Point(475, 100);
            this.pictureBoxDoorRightUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxDoorRightUp.Name = "pictureBoxDoorRightUp";
            this.pictureBoxDoorRightUp.Size = new System.Drawing.Size(125, 330);
            this.pictureBoxDoorRightUp.TabIndex = 10;
            this.pictureBoxDoorRightUp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 845);
            this.Controls.Add(this.pictureBoxDoorRightUp);
            this.Controls.Add(this.pictureBoxDoorLeftUp);
            this.Controls.Add(this.pictureBoxDoorDownRight);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBoxDoorDownLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.pictureBoxElevator);
            this.Name = "Form1";
            this.Text = "Elevator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorDownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorLeftUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorRightUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxElevator;
        private Button btnUp;
        private Button btnDown;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.Timer timerDown;
        private PictureBox pictureBoxDoorDownLeft;
        private Button btnOpen;
        private Button btnClose;
        private System.Windows.Forms.Timer timerOpen;
        private System.Windows.Forms.Timer timerClose;
        private PictureBox pictureBoxDoorDownRight;
        private PictureBox pictureBoxDoorLeftUp;
        private PictureBox pictureBoxDoorRightUp;
    }
}