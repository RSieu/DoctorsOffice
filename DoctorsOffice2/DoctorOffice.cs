using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorsOffice
{
    public class DoctorOffice
    {
        // Creating Properties for the data needed.
        public string PatientName { get; set; }
        public decimal CostOfOfficeVisit { get; set; }
        public decimal PercentInsuranceCoverage { get; set; }
        public decimal PatientCopayAmount { get; set; }
        public decimal InsurancePaidAmount { get; set; }

        //hold whichever plan the user click on the form, and then use that to calculate the copay amount.
        public string InsurancePlan { get; set; }

        //Named Constants (Official Unchangeable Names for the insureance plans and their copay rates).
        public const string PLAN_HMO = "HMO";
        public const string PLAN_PPO = "PPO";
        public const string PLAN_NONE = "None";

        //The Switch Statement method.
        public void SetCoverageRate()
        { 
        // This looks at the string inside InsurancePlan and matches it to a constant
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



        // default constructor
        public DoctorOffice()
        {
            PatientName = "Unknown";
            CostOfOfficeVisit = 0m;
            PercentInsuranceCoverage = 0m;
            InsurancePlan = PLAN_HMO;
        }
        
        //Parameterized Constructor
        public DoctorOffice(string patientName,decimal costOfVisit, decimal percentCoverage)
        {
            PatientName = patientName;
            CostOfOfficeVisit = costOfVisit;
            PercentInsuranceCoverage = percentCoverage;
            InsurancePlan = PLAN_HMO;
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