using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApplication1
{
    class Class2
    {
        public string BuildHTMLTable_PatientDemographics(DataTable dtLabResultsBasedonOBxIDs)
        {
            StringBuilder sbPatientDemogHTML = new StringBuilder();
            string strAllTablesUsedInreport_Border = "border: 1px solid #333333;";
            string strAllTablesUsedInreport_Width = "100%;";
            string strColumnBorderStyle = "1px solid Silver";
            string strColumnNamesWidth = "175px";
            string strColumnValuesWidth = "295px";
            try
            {
                if (dtLabResultsBasedonOBxIDs == null || dtLabResultsBasedonOBxIDs.Rows.Count <= 0)
                    return sbPatientDemogHTML.ToString();


                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["PatientName"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["PatientName"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<tr><td><table cellpadding='1' cellspacing='3' style='" + strAllTablesUsedInreport_Border + "' width='" + strAllTablesUsedInreport_Width + "'>");
                    sbPatientDemogHTML.Append("<tr><td bgcolor=\"CornflowerBlue\" colspan=\"6\" style=\"text-align: center\">MAPPED EMR PATIENT INFORMATION</td></tr>");


                    // ################# ROW - 1 ####################
                    sbPatientDemogHTML.Append("<tr>");
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\">Patient Name  </td>");
                    if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["PatientName"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["PatientName"].ToString().Trim().Length > 0)
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:300px; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["PatientName"] + "</td>");
                    }
                    else
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                    }

                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\">Date of Birth </td>");


                    if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["DateOfBirth"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["DateOfBirth"].ToString().Trim().Length > 0)
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + ";text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["DateOfBirth"] + "</td>");
                    }
                    else
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + ";text-align:left; \">&nbsp;</td>");
                    }

                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\">Gender </td>");


                    if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["PatientGender"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["PatientGender"].ToString().Trim().Length > 0)
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + ";text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["PatientGender"] + "</td>");
                    }
                    else
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + ";text-align:left; \">&nbsp;</td>");
                    }
                    sbPatientDemogHTML.Append("</tr>");
                    // ################# ROW - 1 ####################

                    sbPatientDemogHTML.Append("</table></td></tr>");
                }


                sbPatientDemogHTML.Append("<tr><td><table cellpadding='1' cellspacing='3' style='" + strAllTablesUsedInreport_Border + "' width='" + strAllTablesUsedInreport_Width + "'>");
                sbPatientDemogHTML.Append("<tr><td bgcolor=\"CornflowerBlue\" colspan=\"4\" style=\"text-align:center;\">PATIENT INFORMATION ON RESULT FILE</td></tr>");



                // ################# ROW - 1 ####################
                sbPatientDemogHTML.Append("<tr>");
                sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\">Patient Name </td>");
                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["HL7PatientName"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["HL7PatientName"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["HL7PatientName"] + "</td>");
                }
                else
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                }

                sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\">Patient Identifier </td>");

                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["PatientIdentifier"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["PatientIdentifier"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["PatientIdentifier"] + "</td>");
                }
                else
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                }
                sbPatientDemogHTML.Append("</tr>");
                // ################# ROW - 1 ####################




                // ################# ROW - 2 ####################
                sbPatientDemogHTML.Append("<tr>");
                sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\" >Gender </td>");
                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["Hl7PatientGender"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["Hl7PatientGender"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["Hl7PatientGender"] + "</td>");
                }
                else
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                }

                sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\" dir=\"rtl\"><span dir=\"ltr\">Assigned Authority (Type) </span></td>");

                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["AssignedAuthorityName"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["AssignedAuthorityName"].ToString().Trim().Length > 0 || !object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["AssignedAuthorityTypeCode"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["AssignedAuthorityTypeCode"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["AssignedAuthorityName"]);

                    if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["AssignedAuthorityTypeCode"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["AssignedAuthorityTypeCode"].ToString().Trim().Length > 0)
                    {
                        sbPatientDemogHTML.Append(" (" + dtLabResultsBasedonOBxIDs.Rows[0]["AssignedAuthorityTypeCode"] + ")");
                    }

                    sbPatientDemogHTML.Append("</td>");
                }
                else
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                }
                sbPatientDemogHTML.Append("</tr>");
                // ################# ROW - 2 ####################


                // ################# ROW - 3 ####################
                sbPatientDemogHTML.Append("<tr>");
                sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\">Date of Birth </td>");
                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["HL7PatientDateOfBirth"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["HL7PatientDateOfBirth"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["HL7PatientDateOfBirth"] + "</td>");
                }
                else
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                }

                sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\">Race </td>");

                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["RaceText"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["RaceText"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["RaceText"] + "</td>");
                }
                else
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                }
                sbPatientDemogHTML.Append("</tr>");
                // ################# ROW - 3 ####################


                // ################# ROW - 4 ####################
                sbPatientDemogHTML.Append("<tr>");
                sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\">Address </td>");
                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["PatientAddress"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["PatientAddress"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["PatientAddress"] + "</td>");
                }
                else
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                }

                sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\"><span dir=\"ltr\">Race (Alternative) </span></td>");

                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["AlternativeRaceText"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["AlternativeRaceText"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["AlternativeRaceText"] + "</td>");
                }
                else
                {
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                }
                sbPatientDemogHTML.Append("</tr>");
                // ################# ROW -4 ####################


                sbPatientDemogHTML.Append("</table></td></tr>");

                // strPatientDemogHTML &= "<br/>"



                if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["OrderingProviderName"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["OrderingProviderName"].ToString().Trim().Length > 0)
                {
                    sbPatientDemogHTML.Append("<tr><td><table cellpadding='1' cellspacing='3' style='" + strAllTablesUsedInreport_Border + "' width='" + strAllTablesUsedInreport_Width + "'>");
                    sbPatientDemogHTML.Append("<tr><td bgcolor=\"CornflowerBlue\" colspan=\"4\" style=\"text-align: center\">ORDERING PROVIDER INFORMATION</td></tr>");


                    // ################# ROW - 1 ####################
                    sbPatientDemogHTML.Append("<tr>");
                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\"><span dir=\"ltr\">Ordering Provider Name (Type)</span></td>");
                    if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["OrderingProviderName"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["OrderingProviderName"].ToString().Trim().Length > 0)
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["OrderingProviderName"] + "</td>");
                    }
                    else
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + "; text-align:left; \">&nbsp;</td>");
                    }

                    sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnNamesWidth + "; text-align: right;padding-right: 5px;\"  dir=\"rtl\"><span dir=\"ltr\">ID Number (Type) </span></td>");


                    if (!object.ReferenceEquals(dtLabResultsBasedonOBxIDs.Rows[0]["OrderingProviderID"], DBNull.Value) && dtLabResultsBasedonOBxIDs.Rows[0]["OrderingProviderID"].ToString().Trim().Length > 0)
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + ";text-align:left; \">" + dtLabResultsBasedonOBxIDs.Rows[0]["OrderingProviderID"] + "</td>");
                    }
                    else
                    {
                        sbPatientDemogHTML.Append("<td style=\"border:" + strColumnBorderStyle + "; width:" + strColumnValuesWidth + ";text-align:left; \">&nbsp;</td>");
                    }
                    sbPatientDemogHTML.Append("</tr>");
                    // ################# ROW - 1 ####################

                    sbPatientDemogHTML.Append("</table></td></tr>");

                }

                return sbPatientDemogHTML.ToString();
            }
            finally
            {
            }
        }


        public string BuildHTML_Email(Dictionary<string, string> values, string strTemplate)
        {
            try
            {
                string path = System.IO.Path.Combine(ConfigurationManager.AppSettings["DirectoryPath"] + strTemplate + ".html");

                if (!System.IO.File.Exists(path))
                    return string.Empty;

                StringBuilder sbEmail = new StringBuilder(System.IO.File.ReadAllText(path));

                foreach (string key in values.Keys)
                {
                    sbEmail = sbEmail.Replace("{{" + key + "}}", string.IsNullOrEmpty(values[key]) ? "" : values[key]);
                }

                return sbEmail.ToString();
            }
            finally
            {
            }
        }
    }
}