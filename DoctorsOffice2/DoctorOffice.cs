using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorsOffice2
{
    public class DoctorOffice
    {
        // Creating Properties for the data needed.
        public string PatientName { get; set; }
        public decimal CostOfOfficeVisit { get; set; }
        public decimal PercentInsuranceCoverage { get; set; }
        public decimal PatientCopayAmount { get; set; }
        public decimal InsurancePaidAmount { get; set; }

        // default constructor
        public DoctorOffice()
        {
            PatientName = "Unknown";
            CostOfOfficeVisit = 0m;
            PercentInsuranceCoverage = 0m;
        }
        
        //Parameterized Constructor
        public DoctorOffice(string patientName,decimal costOfVisit, decimal percentCoverage)
        {
            PatientName = patientName;
            CostOfOfficeVisit = costOfVisit;
            PercentInsuranceCoverage = percentCoverage;
        }
        public void CalculateCosts()
        {
            PatientCopayAmount = CostOfOfficeVisit * PercentInsuranceCoverage;
            InsurancePaidAmount = CostOfOfficeVisit - PatientCopayAmount;
        }

        //to string method
        public override string ToString()
        {
            return "Patient Name:\t\t" + PatientName + "\r\n" +
                   "Visit Cost:\t\t" + CostOfOfficeVisit.ToString("c") + "\r\n" +
                   "Copay Rate:\t\t" + PercentInsuranceCoverage.ToString("p0") + "\r\n" +
                   "Insurance Portion:\t" + InsurancePaidAmount.ToString("c") + "\r\n" +
                   "Patient Copay:\t\t" + PatientCopayAmount.ToString("c");
        }



    }
}
