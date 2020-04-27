using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApplication1
{

    class myResult
    {
        public int Addition;
        public int Multiplication;
    }

    class Program
    {
        static void Main(string[] args)
        {


            DataTable dtPatient = new DataTable();
            dtPatient.Columns.Add("PatientName");
            dtPatient.Columns.Add("DateOfBirth");
            dtPatient.Columns.Add("PatientGender");
            dtPatient.Columns.Add("HL7PatientName");
            dtPatient.Columns.Add("PatientIdentifier");
            dtPatient.Columns.Add("Hl7PatientGender");
            dtPatient.Columns.Add("AssignedAuthorityName");
            dtPatient.Columns.Add("AssignedAuthorityTypeCode");
            dtPatient.Columns.Add("HL7PatientDateOfBirth");
            dtPatient.Columns.Add("RaceText");
            dtPatient.Columns.Add("PatientAddress");
            dtPatient.Columns.Add("AlternativeRaceText");
            dtPatient.Columns.Add("OrderingProviderName");
            dtPatient.Columns.Add("OrderingProviderID");

            DataRow drPatient;
            drPatient = dtPatient.NewRow();

            drPatient["PatientName"] = "Test Patient";
            drPatient["DateOfBirth"] = "1980/01/01";
            drPatient["PatientGender"] = "Male";
            drPatient["HL7PatientName"] = "Test Patient";
            drPatient["PatientIdentifier"] = "123";
            drPatient["Hl7PatientGender"] = "Male";
            drPatient["AssignedAuthorityName"] = "TEST AUTH";
            drPatient["AssignedAuthorityTypeCode"] = "ATC01";
            drPatient["HL7PatientDateOfBirth"] = "1980/01/01";
            drPatient["RaceText"] = "IUYTFGJ";
            drPatient["PatientAddress"] = "JGJKHKJ , LH KHLK L";
            drPatient["AlternativeRaceText"] = "LKJHGFZ";
            drPatient["OrderingProviderName"] = "TEST PROVIDER";
            drPatient["OrderingProviderID"] = "123123";

            dtPatient.Rows.Add(drPatient);

            Class2 obj = new Class2();
            //obj.BuildHTMLTable_PatientDemographics(dtPatient);

            Dictionary<string, string> patientDemographic = new Dictionary<string, string>();
            patientDemographic.Add("PatientName", "Test Patient");
            patientDemographic.Add("DateOfBirth", "01/01/1980");
            patientDemographic.Add("PatientGender", "Male");
            patientDemographic.Add("HL7PatientName", "HL7 TEST PATIENT");
            patientDemographic.Add("PatientIdentifier", "123");
            patientDemographic.Add("Hl7PatientGender", "HL7 Male");
            patientDemographic.Add("AssignedAuthorityName", "AUTH ABC");
            patientDemographic.Add("AssignedAuthorityTypeCode", "AUTH001");
            patientDemographic.Add("HL7PatientDateOfBirth", "01/01/1981");
            patientDemographic.Add("RaceText", "KJHGFDSA");
            patientDemographic.Add("PatientAddress", "TX, USA");
            patientDemographic.Add("AlternativeRaceText", "TRFVBJKOIUH");
            patientDemographic.Add("OrderingProviderName", "PROVIDER NAME HERE");
            patientDemographic.Add("OrderingProviderID", "123123");

            obj.BuildHTML_Email(patientDemographic, "PatientEmail");

            //Calculate(10,15)-> *,+
            //myResult resObj = new myResult();
            //resObj = Calculate(10, 15);
        }



        static myResult Calculate(int valA, int valB)
        {
            myResult resObj = new myResult();

            resObj.Addition = valA + valB;
            resObj.Multiplication = valA * valB;

            return resObj;
        }

    }
}
