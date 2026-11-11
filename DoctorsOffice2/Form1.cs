namespace DoctorsOffice2
{
   
    public partial class Form1 : Form
        //Public Classes are Completely open. Acessible from any procedure, class, or external program that references your code.
        //a class is the abstract blueprint.and object is the concrete item built for that blueprint. -- defines structure dictates what properties (variables) and methods (actions) must exist
        //contains no actual data values for those properties
        //exists as a single static definition in your code. 

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Read inputs from the form
            
            string currentPatientName = txtPatientName.Text;
            decimal currentVisitCost = decimal.Parse(txtVisitCost.Text);
            decimal currentCopayRate = 0.25m;

            // 2. Create the DoctorOffice object

            DoctorOffice currentVisit = new DoctorOffice(currentPatientName, currentVisitCost, currentCopayRate);

            // object: working copy created in the computers memory created in the computers memory while the program runs..
            //holds actual, specific data values for the properties defined by the class. 
            // you can instantiate thousands of unique, independent objects from one single class. 
           
            // Class: The original honda engineering schematics for a 1995 civic. The paperwork dictates that every civic will have a PaintColor and an EngineType, and a method to StartEngine(), you cannot drive a schematic.
            // Object: aN ACTUAL 1995 civic eg hatch sitting in the driveway. Its PaintColor is "carmine red" its EngineType is a "K24a2". You could build another object, a 1993 civic sedan from that same class with a D16z6 engine.. They share the same structure but different data.
            // Properties: nouns or adjectives that represent the current state, traits, or characteristics of an object. data that an object holds (PaintColor, EngineType) where you can use get; set; so your program can read or change their values. PatientName, CostOfOfficeVisit, PercentageInsuranceCoverage.
            // Methods: How: Verbs: Functions that live inside the object, inside the civic or doctors office. Like CalculateCopay() or StartEngine() or EngageVtec() and have acess to the current information important to them.. 
            
            
            // an objects purpose in coding is to bundle related data and the actions that operate on that data into a single, organized unit. Instead of having dozens of loose variables and functions floating around a program, objects let you structure code to mimic real-world objects. 
            // holding state:(properties) it stores specific data it needs to know at that moment, like a patients name, their insurance provider, or their visit type. 
            // performing actions (methods): it knows how to use its own data do to work, like calculating the final copay or updating a balance without needing an outside script to do math for it. 
            // by using objects code becomes reusable 
            
            // 3. TRIGGER THE CALCULATION
            currentVisit.CalculateCosts();

            // 4. OUTPUT TO LISTBOX
            
            lstOutput.Items.Clear();

            // Call the ToString() method and split it by newlines so it displays correctly in the ListBox
            string[] outputLines = currentVisit.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (string line in outputLines)
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