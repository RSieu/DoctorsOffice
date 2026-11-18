using System;
using System.Collections.Generic;
using System.Text;

//Namespace: Folder for organization.

namespace DoctorsOffice
{
    // Class: Blueprint for the Doctors Office Object. It is a template for creating objects that represent a doctor's office visit. It defines the properties and methods that an object of this class will have.

    public class DoctorOffice 
    {
        // Data that an object holds.. current state, traits. [PatientName,CostOfOfficeVisit.]
        public string PatientName { get; set; }
        public string InsurancePlan { get; set; }

        // constants: are unchangeable values used through the program.
        public const string PLAN_HMO = "HMO";
        public const string PLAN_PPO = "PPO";
        public const string PLAN_NONE = "None";

        // decimals: are assigned to Propeties that will be used in calculations..decimal is a data type that can hold numbers with decimal points.
        public decimal CostOfOfficeVisit { get; set; }
        public decimal PercentInsuranceCoverage { get; set; }
        public decimal InsurancePaidAmount { get; set; }
        public decimal PatientCopayAmount { get; set; }
        
        // Switch Statement: is a way to check a variable (InsurancePlan) against a list of values (constants) and executes different code depending on which value it matches.
        public void SetCoverageRate()
        { 
        switch (InsurancePlan)
        {
            case PLAN_HMO:
                PercentInsuranceCoverage = 0.15m;
                break;
            case PLAN_PPO:
                PercentInsuranceCoverage = 0.25m;
                break;
            case PLAN_NONE:
                PercentInsuranceCoverage = 1.00m;
                break;
            default:
                PercentInsuranceCoverage = 1.00m;
                break;
        }
}
        // Default DoctorOffice Constructor: It is a special method that is called when an object is created (contructor). It has the same name as the class (DoctorOffice) and no return type.
        public DoctorOffice()
        {
            PatientName = "Unknown";
            CostOfOfficeVisit = 0m;
            PercentInsuranceCoverage = 0m;
            InsurancePlan = PLAN_HMO;
        }

        // Parameterized Constructor: Allows you to create a DoctorOffice object with specific values for PatientName, CostOfOfficeVisit, and InsurancePlan. It also calls the CalculateCosts() method to calculate the insurance coverage and copay amounts based on the provided values.
        public DoctorOffice(string patientName,decimal costOfVisit, string plan)
        {
            PatientName = patientName;
            CostOfOfficeVisit = costOfVisit;
            InsurancePlan = plan;
            
            //this will trigger SetCoverageRate() to set the correct percentage based on the plan selected.
            CalculateCosts();
        }
        public void CalculateCosts()
        {
        // Trigger the switch statement first to get the right percentage
        SetCoverageRate();

        // Now do the math with that percentage
        PatientCopayAmount = CostOfOfficeVisit * PercentInsuranceCoverage;
        InsurancePaidAmount = CostOfOfficeVisit - PatientCopayAmount;
}

//to string method
public override string ToString()
        {
            return "Patient Name:\t\t" + PatientName + "\n" +
                   "Visit Cost:\t\t" + CostOfOfficeVisit.ToString("c") + "\n" +
                   "Copay Rate:\t\t" + PercentInsuranceCoverage.ToString("p0") + "\n" +
                   "Insurance Portion:\t" + InsurancePaidAmount.ToString("c") + "\n" +
                   "Patient Copay:\t\t" + PatientCopayAmount.ToString("c");
        }



    }
}

// Class: The original honda engineering schematics for a 1995 civic. The paperwork dictates that every civic will have a PaintColor and an EngineType, and a method to StartEngine(), you cannot drive a schematic.

// Object: aN ACTUAL 1995 civic eg hatch sitting in the driveway. Its PaintColor is "carmine red" its EngineType is a "K24a2". You could build another object, a 1993 civic sedan from that same class with a D16z6 engine.. They share the same structure but different data.

// Properties: nouns or adjectives that represent the current state, traits, or characteristics of an object. data that an object holds (PaintColor, EngineType) where you can use get; set; so your program can read or change their values. PatientName, CostOfOfficeVisit, PercentageInsuranceCoverage.  

// holding state:(properties) it stores specific data it needs to know at that moment, like a patients name, their insurance provider, or their visit type.

// Methods: How: Verbs: Functions that live inside the object, inside the civic or doctors office. Like CalculateCopay() or StartEngine() or EngageVtec() and have acess to the current information important to them..

// performing actions (methods): it knows how to use its own data do to work, like calculating the final copay or updating a balance without needing an outside script to do math for it. 
// by using objects code becomes reusable 

//Constructors: are special methods that are called when an object is created. They have the same name as the class and no return type. They can be used to set default values for properties or to initialize an object with specific values.