using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoctorsOffice
{
    public partial class Form1 : Form
    {
    string selectedPlan = DoctorOffice.PLAN_HMO;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radHMO.Checked = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Read inputs from the form (The receptionist collecting raw data)

            string inputName = txtPatientName.Text;

            //stage 3

            bool isCostValid = decimal.TryParse(txtVisitCost.Text, out decimal inputCost);
            //decimal tempCopayRate = 0.25m; // killed for stage 3

            // 2. Print a fresh clipboard and write the inputs onto it
            if (isCostValid)
            {
                // 2. Print a fresh clipboard and write the inputs onto it
                //use parametized version
                DoctorOffice patientClipboard = new DoctorOffice();

                patientClipboard.PatientName = inputName;
                patientClipboard.CostOfOfficeVisit = inputCost;
                patientClipboard.InsurancePlan = selectedPlan;

                //tell the clipboard to do its own mathq
                patientClipboard.CalculateCosts();

                // 4. Get the receipt and put it in the ListBox
                // lstOutput.Items.Clear();
                string[] receiptLines = patientClipboard.ToString().Split('\n');

                foreach (string line in receiptLines)
                {
                    lstOutput.Items.Add(line);
                }
            }
            else
            {
                //error message coded in the else portion and displayed in list box.
                lstOutput.Items.Clear();
                lstOutput.Items.Add("Please enter a valid cost for the office visit.");
            }
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
    txtPatientName.Clear();
            txtVisitCost.Clear();
            lstOutput.Items.Clear();
            radHMO.Checked = true;
            txtPatientName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
{
    //Stage 3: Message box for quitting
    DialogResult response = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    if (response == DialogResult.Yes)
    {
        this.Close();
    }
}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPatientName_Enter(object sender, EventArgs e)
        {
            txtPatientName.BackColor = Color.LightYellow;
        }

        private void txtPatientName_Leave(object sender, EventArgs e)
        {
            txtPatientName.BackColor = Color.White;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radHMO_CheckedChanged(object sender, EventArgs e)
        {
            if (radHMO.Checked) selectedPlan = DoctorOffice.PLAN_HMO;
        }

        private void radPPO_CheckedChanged(object sender, EventArgs e)
        {
            if (radPPO.Checked) selectedPlan = DoctorOffice.PLAN_PPO;
        }
        private void radNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radNone.Checked)
            {
                selectedPlan = DoctorOffice.PLAN_NONE;
            }
            //when using if statements need brackets.
        }
    }
}
//a namespace is a container that holds classes, variables, and properties
//Public Classes are Completely open. Acessible from any procedure, class, or external program that references your code.
//a class is the abstract blueprint.and object is the concrete item built for that blueprint. -- defines structure dictates what properties (variables) and methods (actions) must exist
//contains no actual data values for those properties
//exists as a single static definition in your code.