using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkOutApp
{
    public partial class FrmWorkOutApp : Form
    {
        public FrmWorkOutApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workoutsDataSet.upper_body' table. You can move, or remove it, as needed.
            CboWU1.Items.AddRange(bodyTarget);
            CboWU2.Items.AddRange(bodyTarget);
            CboWU3.Items.AddRange(bodyTarget);
            CboWO1.Items.AddRange(bodyTarget);
            CboWO2.Items.AddRange(bodyTarget);
            CboWO3.Items.AddRange(bodyTarget);
            CboWO4.Items.AddRange(bodyTarget);
            CboWO5.Items.AddRange(bodyTarget);
            CboWO6.Items.AddRange(bodyTarget);
            CboWO7.Items.AddRange(bodyTarget);
            CboWO8.Items.AddRange(bodyTarget);
            CboWO9.Items.AddRange(bodyTarget);
        }

        // Data structures for containing exercises
        string[] bodyTarget = { "Upper Body", "Arms", "Hips and Groin", "Legs", "Core" };
        public static string[] upperBody = { "Press Up", "Wide Press Up", "Chin Up", "Crow Pose", "Bent Over Rows"};
        public static string[] arms = { "Bicep Curls", "Tricep Dips", "Forearm Squeeze", "Upright Row", "Side Curls"};
        public static string[] hipsGroin = {"Hip Opener", "Knee Squeeze", "Walking Dips", "Downward Dog", "Band Kicks"};
        public static string[] legs = { "Leg lifts", "Wall Squats", "Split Squat", "Jumping Squats", "Romanian Deadlift" };
        public static string[] core = { "Plank", "Deadbug", "Deadlift", "Walking Planks", "Leg Raise"};


        // Random number variable for work out selection
        private static Random rnd = new Random();

        // Custom box drop downs
        private void CboWU1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CboWU2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CboWU3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Work out Set 1
        private void CboWO1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CboWO2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CboWO3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Work out Set 2
        private void CboWO4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CboWO5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CboWO6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Work out Set 3
        private void CboWO7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboWO8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CboWO9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Text Box Warm-up block
        private void TxtWU1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtWU2_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtWU3_TextChanged(object sender, EventArgs e)
        {

        }

        // Text Box Work Out 1

        private void TxtWO1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtWO2_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtWO3_TextChanged(object sender, EventArgs e)
        {

        }

        // Text Box Work Out 2
        private void TxtWO4_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtWO5_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtWO6_TextChanged(object sender, EventArgs e)
        {

        }

        // Text Box Work Out 3

        private void TxtWO7_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtWO8_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtWO9_TextChanged(object sender, EventArgs e)
        {

        }

        
        // Method for building a random work out
        public void Builder (string choice, ref string output){
            switch (choice)
            {
                case "Upper Body":
                    output = upperBody[rnd.Next(0, upperBody.Length - 1)];
                    break;

                case "Arms":
                    output = arms[rnd.Next(0, arms.Length - 1)];
                    break;

                case "Hips and Groin":
                    output = hipsGroin[rnd.Next(0, hipsGroin.Length - 1)];
                    break;

                case "Legs":
                    output = legs[rnd.Next(0, legs.Length - 1)];
                    break;
                case "Core":
                    output = core[rnd.Next(0, core.Length - 1)];
                    break;
            }
        }

        // Activation buttons
        private void BtnWU1_Click(object sender, EventArgs e)
        {
            string choice = CboWU1.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWU1.Text = output;
        }

        private void BtnWU2_Click(object sender, EventArgs e)
        {
            string choice = CboWU2.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWU2.Text = output;
        }

        private void BtnWU3_Click(object sender, EventArgs e)
        {
            string choice = CboWU3.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWU3.Text = output;
        }

        private void BtnWO1_Click(object sender, EventArgs e)
        {
            string choice = CboWO1.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO1.Text = output;
        }

        private void BtnWO2_Click(object sender, EventArgs e)
        {
            string choice = CboWO2.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO2.Text = output;
        }

        private void BtnWO3_Click(object sender, EventArgs e)
        {
            string choice = CboWO3.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO3.Text = output;
        }

        private void BtnWO4_Click(object sender, EventArgs e)
        {
            string choice = CboWO4.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO4.Text = output;
        }

        private void BtnWO5_Click(object sender, EventArgs e)
        {
            string choice = CboWO5.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO5.Text = output;
        }

        private void BtnWO6_Click(object sender, EventArgs e)
        {
            string choice = CboWO6.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO6.Text = output;
        }

        private void BtnWO7_Click(object sender, EventArgs e)
        {
            string choice = CboWO7.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO7.Text = output;
        }

        private void BtnWO8_Click(object sender, EventArgs e)
        {
            string choice = CboWO8.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO8.Text = output;
        }

        private void BtnWO9_Click(object sender, EventArgs e)
        {
            string choice = CboWO9.SelectedItem.ToString();
            string output = "";
            Builder(choice, ref output);
            TxtWO9.Text = output;

        }


    }

}
