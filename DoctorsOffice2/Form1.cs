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

            // 1. Now, reading inputs from the form.
            //- block start
            //patientName in string 
            string currentPatientName = txtPatientName.Text;
            string currentInsurancePlan = txtInsurancePlan.Text;
            decimal currentVisitCost = decimal.Parse(txtVisitCost.Text);
            decimal currentCopayRate = 0.25m;
            // create object?
            DoctorOffice currentVisit = new DoctorOffice(currentPatientName, currentVisitCost, currentCopayRate);

            //math using the Objects properties instead of loose variables
            decimal patientCopayAmount = currentVisit.CostOfOfficeVisit * currentVisit.PercentInsuranceCoverage;
            decimal insurancePaidAmount = currentVisit.CostOfOfficeVisit - patientCopayAmount;
            
            // 4. Output lines to the ListBox
            lstOutput.Items.Clear();
            lstOutput.Items.Add("Patient Name:\t\t" + currentVisit.PatientName);
            lstOutput.Items.Add("Insurance Plan:\t\t" + currentInsurancePlan);
            lstOutput.Items.Add("Visit Cost:\t\t" + currentVisit.CostOfOfficeVisit.ToString("c"));
            lstOutput.Items.Add("Copay Rate:\t\t" + currentVisit.PercentInsuranceCoverage.ToString("p0"));
            lstOutput.Items.Add("Insurance Portion:\t\t" + insurancePaidAmount.ToString("c"));
            lstOutput.Items.Add("Patient Copay:\t\t" + patientCopayAmount.ToString("c"));
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