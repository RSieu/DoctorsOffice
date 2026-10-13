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
    }
}
