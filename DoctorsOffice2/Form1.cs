using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoctorsOffice
{
    public partial class Form1 : Form
    {
        string selectedPlan = DoctorOffice.PLAN_NONE;
        private string transactionFileName = "TransactionOutput.txt";
        private const int LISTBOX = 1;
        private const int FILE = 2;
        private const int BOTH = 3;
        public Form1()

        {
            InitializeComponent();
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
                DoctorOffice patientClipboard = new DoctorOffice(inputName, inputCost, selectedPlan);

                // Output
                outputMsg("************** Transaction Output at " + DateTime.Now.ToString("G") + " ****************", FILE);
                outputMsg(patientClipboard.ToString(), BOTH);
            }
            else
            {
                outputMsg("Please enter a valid cost for the office visit.", LISTBOX);
            }

        }
        private void outputMsg(string msg, int type)
        {
            StreamWriter sw;
            if (type == FILE || type == BOTH)
            {
                sw = File.AppendText(transactionFileName);
                sw.WriteLine(msg);
                sw.Close();
            }
            if (type == LISTBOX || type == BOTH)
            {
                string[] lines = msg.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    lstOutput.Items.Add(lines[i]);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientName.Clear();
            txtVisitCost.Clear();
            lstOutput.Items.Clear();
            radNone.Checked = true;
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
            {
                // Most likely will be adding to for later. It is good practice to leave the brackets in place for future code additions.
            }
        }

        private void radPPO_CheckedChanged(object sender, EventArgs e)
        {
            if (radPPO.Checked) selectedPlan = DoctorOffice.PLAN_PPO;
            {
                // if
            }
        }
        private void radNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radNone.Checked)
            {
                selectedPlan = DoctorOffice.PLAN_NONE;
            }
            //when using if statements need brackets.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radNone.Checked = true;
        }
    }
}
//a namespace is a container that holds classes, variables, and properties
//Public Classes are Completely open. Acessible from any procedure, class, or external program that references your code.
//a class is the abstract blueprint.and object is the concrete item built for that blueprint. -- defines structure dictates what properties (variables) and methods (actions) must exist
//contains no actual data values for those properties
//exists as a single static definition in your code.