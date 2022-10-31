namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {

            pictureBoxElevator.Location = new Point(pictureBoxElevator.Location.X, pictureBoxElevator.Location.Y-10);
            timerUp.Enabled = true;

            if (pictureBoxElevator.Location.Y <= 100)
            {
                timerUp.Enabled = false;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
         
            
                if (timerDown.Enabled == false)
                {
                    timerClose.Enabled = true;
                    if(pictureBoxDoorDownLeft.Location.X >= 350 && pictureBoxDoorDownRight.Location.X <= 475)
                    {
                        timerUp.Enabled = true;
                    }
                    
                    
                }

                timerOpen.Enabled = true;



        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            pictureBoxElevator.Location = new Point(pictureBoxElevator.Location.X, pictureBoxElevator.Location.Y + 10);
            timerDown.Enabled = true;

            if (pictureBoxElevator.Location.Y >= 450)
            {
                timerDown.Enabled = false;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            /*if (timerUp.Enabled == false)
            {
                timerDown.Enabled = true;
            }*/

            if (timerUp.Enabled == false)
            {
                timerClose.Enabled = true;
                if (pictureBoxDoorLeftUp.Location.X >= 350 && pictureBoxDoorRightUp.Location.X <= 475)
                {
                    timerDown.Enabled = true;
                }

                timerOpen.Enabled = true;
            }

        }

        private void timerOpen_Tick(object sender, EventArgs e)
        {
            if (pictureBoxElevator.Location.Y == 450)
            {

                pictureBoxDoorDownLeft.Location = new Point(pictureBoxDoorDownLeft.Location.X - 10, pictureBoxDoorDownLeft.Location.Y);
                pictureBoxDoorDownRight.Location = new Point(pictureBoxDoorDownRight.Location.X + 10, pictureBoxDoorDownRight.Location.Y);
                timerOpen.Enabled = true;

                if (pictureBoxDoorDownLeft.Location.X <= 230 && pictureBoxDoorDownRight.Location.X >= 400)
                {
                    timerOpen.Enabled = false;
                }

            }

            else if(pictureBoxElevator.Location.Y == 100)
            {
                pictureBoxDoorLeftUp.Location = new Point(pictureBoxDoorLeftUp.Location.X - 10, pictureBoxDoorLeftUp.Location.Y);
                pictureBoxDoorRightUp.Location = new Point(pictureBoxDoorRightUp.Location.X + 10, pictureBoxDoorRightUp.Location.Y);

                if (pictureBoxDoorLeftUp.Location.X <= 230 && pictureBoxDoorRightUp.Location.X >= 400)
                {
                    timerOpen.Enabled = false;
                }
            }

            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            timerOpen.Enabled = true;
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (pictureBoxElevator.Location.Y == 450)
            {

                pictureBoxDoorDownLeft.Location = new Point(pictureBoxDoorDownLeft.Location.X + 10, pictureBoxDoorDownLeft.Location.Y);
                pictureBoxDoorDownRight.Location = new Point(pictureBoxDoorDownRight.Location.X - 10, pictureBoxDoorDownRight.Location.Y);

                if (pictureBoxDoorDownLeft.Location.X >= 350 && pictureBoxDoorDownRight.Location.X <= 475)
                {
                    timerClose.Enabled = false;
                }

            }

            else if (pictureBoxElevator.Location.Y == 100)
            {
                pictureBoxDoorLeftUp.Location = new Point(pictureBoxDoorLeftUp.Location.X + 10, pictureBoxDoorLeftUp.Location.Y);
                pictureBoxDoorRightUp.Location = new Point(pictureBoxDoorRightUp.Location.X - 10, pictureBoxDoorRightUp.Location.Y);

                if (pictureBoxDoorLeftUp.Location.X >= 350 && pictureBoxDoorRightUp.Location.X <= 475)
                {
                    timerClose.Enabled = false;
                }
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timerClose.Enabled = true;
        }
    }
}