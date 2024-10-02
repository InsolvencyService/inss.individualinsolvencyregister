﻿using System.Xml;
using INSS.EIIR.DataSync.Application.UseCase.SyncData.Model;

namespace INSS.EIIR.DataSync.Infrastructure.Sink.XML
{
    public static class IirXMLWriterHelper
    {

        public static async Task<MemoryStream> WriteIirReportRequestToStream(InsolventIndividualRegisterModel model, MemoryStream xmlStream)
        {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Async = true;
            settings.OmitXmlDeclaration = true;

            using (XmlWriter writer = XmlWriter.Create(xmlStream, settings))
            {
                await writer.WriteStartElementAsync(null, "ReportRequest", null);
                await writer.WriteRawAsync("\r\n");
                await writer.WriteStartElementAsync(null, "ExtractDate", null);
                await writer.WriteStringAsync(DateTime.Now.ToString("dd/MM/yyyy"));
                await writer.WriteEndElementAsync();
                await writer.WriteStartElementAsync(null, "CaseNoReportRequest", null);
                await writer.WriteStringAsync($"{model.caseNo}");
                await writer.WriteEndElementAsync();
                await writer.WriteStartElementAsync(null, "IndividualDetailsText", null);
                await writer.WriteStringAsync($"Individual Details");
                await writer.WriteEndElementAsync();
                xmlStream = await WriteIirIndividualDetailsToStream(model, xmlStream);
                await writer.WriteStartElementAsync(null, "CaseDetailsText", null);
                await writer.WriteStringAsync($"Insolvency Case Details");
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteRawAsync("\r\n");
                await writer.FlushAsync();
            }

            return xmlStream;
        }


        public static async Task<MemoryStream> WriteIirIndividualDetailsToStream(InsolventIndividualRegisterModel model, MemoryStream xmlStream)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Async = true;
            settings.OmitXmlDeclaration = true;

            using (XmlWriter writer = XmlWriter.Create(xmlStream, settings))
            {
                await writer.WriteStartElementAsync(null, "IndividualDetails", null);

                await writer.WriteStartElementAsync(null, "CaseNoIndividual", null);
                await writer.WriteStringAsync($"{model.caseNo}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "Title", null);
                await writer.WriteStringAsync($"{model.individualTitle}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "Gender", null);
                await writer.WriteStringAsync($"{model.individualGender}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "FirstName", null);
                await writer.WriteStringAsync($"{model.individualForenames}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "Surname", null);
                await writer.WriteStringAsync($"{model.individualSurname}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "Occupation", null);
                await writer.WriteStringAsync($"{model.individualOccupation}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "DateofBirth", null);
                await writer.WriteStringAsync($"{model.individualDOB}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "LastKnownAddress", null);
                await writer.WriteStringAsync($"{model.individualAddress}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "LastKnownPostCode", null);
                await writer.WriteStringAsync($"{model.individualPostcode}");
                await writer.WriteEndElementAsync();

                await writer.WriteStartElementAsync(null, "OtherNames", null);
                await writer.WriteStringAsync($"{model.individualAlias}");
                await writer.WriteEndElementAsync();

                await writer.WriteEndElementAsync();
                await writer.WriteRawAsync("\r\n");
                await writer.FlushAsync();
            }

            return xmlStream;
        }
    }
}
