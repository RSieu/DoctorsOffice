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
            decimal inputCost = decimal.Parse(txtVisitCost.Text);
            //decimal tempCopayRate = 0.25m; // killed for stage 3

            // 2. Print a fresh clipboard and write the inputs onto it

            DoctorOffice patientClipboard = new DoctorOffice();

            patientClipboard.PatientName = inputName;
            patientClipboard.CostOfOfficeVisit = inputCost;
            patientClipboard.InsurancePlan = selectedPlan;

            // 3. Tell the clipboard to do its own math
            patientClipboard.CalculateCosts();

            // 4. Get the receipt and put it in the ListBox
            lstOutput.Items.Clear();

            string[] receiptLines = patientClipboard.ToString().Split('\n');
            //Look at this giant receipt, and every time you see the newline character (\n), cut the paper right there."
            ////nd do whatever is inside the curly brackets."In C#, a "stack" or list of items is called an Array,
            //which is why we save it as string[] (the brackets mean "an array of strings"). We named this stack receiptLines

            foreach (string line in receiptLines)
            //For each individual piece of paper in my receiptLines. For each individual piece of paper in my receiptLines
            {
                lstOutput.Items.Add(line);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientName.Clear();
            //txtInsurancePlan.Clear();
            txtVisitCost.Clear();
            lstOutput.Items.Clear();
            radHMO.Checked = true;
            txtPatientName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (radNone.Checked) selectedPlan = DoctorOffice.PLAN_NONE; 
        }
    }
}
//a namespace is a container that holds classes, variables, and properties
//Public Classes are Completely open. Acessible from any procedure, class, or external program that references your code.
//a class is the abstract blueprint.and object is the concrete item built for that blueprint. -- defines structure dictates what properties (variables) and methods (actions) must exist
//contains no actual data values for those properties
//exists as a single static definition in your code.