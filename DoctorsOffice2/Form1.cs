namespace DoctorsOffice2
{
   
    public partial class Form1 : Form
        //Completely open. Acessible from any procedure, class, or external program that references your code.
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        // Private / Field: declared at the class level (outside any single method) with the 'private' keyword.
        //Every method/procedure inside that class can share and modify it. but code in other classes cannot acesss it directly.
        {
            // Calculation logic will go here

            // 1. Declare all variables upfront
            //- block start
            //patientName in string 
            string patientName;
            string insurancePlan;
            decimal visitCost;
            decimal copayRate;
            decimal patientCopayAmount;
            decimal insurancePaidAmount;
            //
            // 2. Read inputs into variables
            patientName = txtPatientName.Text;
            insurancePlan = txtInsurancePlan.Text;
            visitCost = decimal.Parse(txtVisitCost.Text);

            // 3. Interim math stored in variables
            copayRate = 0.20m;
            patientCopayAmount = visitCost * copayRate;
            insurancePaidAmount = visitCost - patientCopayAmount;

            // 4. Output lines to the ListBox
            lstOutput.Items.Clear();
            lstOutput.Items.Add("Patient Name:\t\t" + patientName);
            lstOutput.Items.Add("Insurance Plan:\t\t" + insurancePlan);
            lstOutput.Items.Add("Visit Cost:\t\t" + visitCost.ToString("c"));
            lstOutput.Items.Add("Copay Rate:\t\t" + copayRate.ToString("p0"));
            lstOutput.Items.Add("Patient Copay:\t\t" + patientCopayAmount.ToString("c"));
            lstOutput.Items.Add("Insurance Portion:\t" + insurancePaidAmount.ToString("c"));
            //block end
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientName.Clear();
            txtInsurancePlan.Clear();
            txtVisitCost.Clear();
            lstOutput.Items.Clear();
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
    }
}