﻿using Azure;
using INSS.EIIR.DataSync.Application.UseCase.SyncData.Model;
using INSS.EIIR.Models.CaseModels;
using INSS.EIIR.Models.Constants;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using INSS.EIIR.Models.AutoMapperProfiles;
using INSS.EIIR.Models.IndexModels;

namespace INSS.EIIR.DataSync.Infrastructure.Tests.EiirXmlWriter
{
    public static class EiirXmlWriterTestsData
    {
        public static IEnumerable<object[]> GetEiirXmlWriterData()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new IndividualSearchMapper());
                mc.AddProfile(new INSS.EIIR.DataSync.Infrastructure.Source.SQL.Models.AutoMapperProfiles.InsolventIndividualRegisterModelMapper());
                mc.AddProfile(new INSS.EIIR.DataSync.Application.UseCase.SyncData.AutoMapperProfiles.InsolventIndividualRegisterModelMapper());
            });

            var mapper = new Mapper(mapperConfig);

            //Ok I know I'm a bad booy for using .Result, but how is one to do it otherwise
            //Perhaps excusable in tests
            return ResultData(mapper).ToListAsync().Result;
        }

        public async static IAsyncEnumerable<object[]> ResultData(Mapper mapper)
        {

            var values = new List<object[]>();

            var expectedresults = new Dictionary<int, string> (){ };
            expectedresults.Add(123589635,$"<ReportRequest><ExtractDate>01/10/2024</ExtractDate><CaseNoReportRequest>123589635</CaseNoReportRequest><IndividualDetailsText>Individual Details</IndividualDetailsText><IndividualDetails><CaseNoIndividual>123589635</CaseNoIndividual><Title>Mr</Title><Gender>Male</Gender><FirstName>JULIAN CARL</FirstName><Surname>GRANT-RIDDLE</Surname><Occupation>No Occupation Found</Occupation><DateofBirth>12/06/1960</DateofBirth><LastKnownAddress>4 Castle St, Conwy, United Kingdom</LastKnownAddress><LastKnownPostCode>LL32 8AY</LastKnownPostCode><OtherNames>No OtherNames Found</OtherNames></IndividualDetails><CaseDetailsText>Insolvency Case Details</CaseDetailsText><CaseDetails><CaseNoCase>123589635</CaseNoCase><CaseName>Julian Carl Grant-Riddle</CaseName><Court>County Court at Carmarthen</Court><CaseType>Bankruptcy</CaseType><CourtNumber>0000076</CourtNumber><CaseYear>2024</CaseYear><StartDate>22/05/2024</StartDate><Status>Currently Bankrupt : Automatic Discharge  will be  22 May 2025</Status><CaseDescription>Julian Carl Grant-Riddle trading as ABC Buildersresiding and carrying on business at 4 Castle St Conwy LL32 8AY</CaseDescription><TradingNames>No Trading Names Found</TradingNames></CaseDetails><InsolvencyPractitionerText>Insolvency Practitioner Contact Details</InsolvencyPractitionerText><IP><CaseNoIP>123589635</CaseNoIP><MainIP>Carl Freeman</MainIP><MainIPFirm>PKF Littlejohn Advisory</MainIPFirm><MainIPFirmAddress>15 Westferry Circus, LONDON, United Kingdom</MainIPFirmAddress><MainIPFirmPostCode>E14 4HD</MainIPFirmPostCode><MainIPFirmTelephone>020 7516 2200</MainIPFirmTelephone></IP><InsolvencyContactText>Insolvency Service Contact Details</InsolvencyContactText><InsolvencyContact><CaseNoContact>123589635</CaseNoContact><InsolvencyServiceOffice>Cardiff</InsolvencyServiceOffice><Contact>Enquiry Desk</Contact><ContactAddress>PO Box 16655, BIRMINGHAM, United Kingdom</ContactAddress><ContactPostCode>B2 2EP</ContactPostCode><ContactTelephone>0300 678 0016</ContactTelephone></InsolvencyContact></ReportRequest>");
            expectedresults.Add(705489723,$"<ReportRequest><ExtractDate>08/08/2024</ExtractDate><CaseNoReportRequest>705489723</CaseNoReportRequest><IndividualDetailsText>Individual Details</IndividualDetailsText><IndividualDetails><CaseNoIndividual>705489723</CaseNoIndividual><Title>Mrs</Title><Gender>Female</Gender><FirstName>ANAS IMOGEN</FirstName><Surname>REID</Surname><Occupation>Unemployed</Occupation><DateofBirth>12/03/1993</DateofBirth><LastKnownAddress>276 Stockport Rd, Gee Cross, Hyde, United Reiddom</LastKnownAddress><LastKnownPostCode>SK14 5RF</LastKnownPostCode><OtherNames><OtherName>GEMMA MORGAN</OtherName><OtherName>GEMMA AGUIRRE</OtherName></OtherNames></IndividualDetails><CaseDetailsText>Insolvency Case Details</CaseDetailsText><CaseDetails><CaseNoCase>705489723</CaseNoCase><CaseName>Anas Imogen Reid</CaseName><Court>(Court does not apply to DRO)</Court><CaseType>Debt Relief Order</CaseType><CourtNumber>7121348</CourtNumber><CaseYear>2024</CaseYear><StartDate>09/04/2024</StartDate><Status>Debt Relief Order Revoked on 25 June 2024</Status><CaseDescription>Anas Imogen Reid, Unemployed of 276 Stockport Rd, Gee Cross, Hyde, Greater Manchester, SK14 5RF,United Reiddom formerly of 9 Pavilion Gardens, Westhoughton, Bolton BL5 3AJ, United Reiddom</CaseDescription><TradingNames>No Trading Names Found</TradingNames></CaseDetails><InsolvencyContactText>Insolvency Service Contact Details</InsolvencyContactText><InsolvencyContact><CaseNoContact>705489723</CaseNoContact><InsolvencyServiceOffice>DRO Team</InsolvencyServiceOffice><Contact>Enquiry Desk</Contact><ContactAddress>1st Floor, Cobourg House, Mayflower Street, PLYMOUTH, United Kingdom</ContactAddress><ContactPostCode>PL1 1DJ</ContactPostCode><ContactTelephone>0300 678 0015</ContactTelephone></InsolvencyContact></ReportRequest>");
            expectedresults.Add(70235351, $"<ReportRequest><ExtractDate>08/08/2024</ExtractDate><CaseNoReportRequest>70235351</CaseNoReportRequest><IndividualDetailsText>Individual Details</IndividualDetailsText><IndividualDetails><CaseNoIndividual>70235351</CaseNoIndividual><Title>MR</Title><Gender>Male</Gender><FirstName>WILHELMINA ANNE</FirstName><Surname>AMES</Surname><Occupation>Unemployed</Occupation><DateofBirth>13/04/1964</DateofBirth><LastKnownAddress></LastKnownAddress><LastKnownPostCode>BA22 7ND</LastKnownPostCode><OtherNames>No OtherNames Found</OtherNames></IndividualDetails><CaseDetailsText>Insolvency Case Details</CaseDetailsText><CaseDetails><CaseNoCase>70235351</CaseNoCase><CaseName>WILHELMINA ANNE AMES</CaseName><Court>County Court at Yeovil</Court><CaseType>Bankruptcy</CaseType><CourtNumber>0000613</CourtNumber><CaseYear>2007</CaseYear><StartDate>06/08/2007</StartDate><Status>Discharge Suspended Indefinitely (from 03/03/2008)</Status><CaseDescription>WILHELMINA ANNE AMES OCCUPATION UNKNOWN OF 18 Grange Road SWINDON SN83 3YT</CaseDescription><TradingNames>No Trading Names Found</TradingNames></CaseDetails><InsolvencyContactText>Insolvency Service Contact Details</InsolvencyContactText><InsolvencyContact><CaseNoContact>70235351</CaseNoContact><InsolvencyServiceOffice>Exeter</InsolvencyServiceOffice><Contact>Enquiry Desk</Contact><ContactAddress>Senate Court, Southernhay Gardens, EXETER, United Kingdom</ContactAddress><ContactPostCode>EX1 1UG</ContactPostCode><ContactTelephone>01392 889650</ContactTelephone></InsolvencyContact></ReportRequest>");
            expectedresults.Add(365896321,$"<ReportRequest><ExtractDate>08/08/2024</ExtractDate><CaseNoReportRequest>365896321</CaseNoReportRequest><IndividualDetailsText>Individual Details</IndividualDetailsText><IndividualDetails><CaseNoIndividual>365896321</CaseNoIndividual><Title>Mr</Title><Gender>Male</Gender><FirstName>SIDNEY ROBYN</FirstName><Surname>HAYES</Surname><Occupation>Unemployed</Occupation><DateofBirth>18/07/1966</DateofBirth><LastKnownAddress>6 St Fagans St, Caerphilly, Holywell, United Kingdom</LastKnownAddress><LastKnownPostCode>CF83 1FZ</LastKnownPostCode><OtherNames>No OtherNames Found</OtherNames></IndividualDetails><CaseDetailsText>Insolvency Case Details</CaseDetailsText><CaseDetails><CaseNoCase>365896321</CaseNoCase><CaseName>Sidney Robyn Hayes</CaseName><Court>Office of the Adjudicator</Court><CaseType>Bankruptcy</CaseType><CourtNumber>5088435</CourtNumber><CaseYear>2019</CaseYear><StartDate>16/10/2019</StartDate><Status>Discharged On 17 June 2024</Status><CaseDescription>Sidney Robyn Hayes, Employed, Director, of 6 St Fagans St, Caerphilly, Holywell, Flintshire, CF83 1FZ,   formerly of 138 High St, Billericay CM12 9DF</CaseDescription><TradingNames>No Trading Names Found</TradingNames></CaseDetails><InsolvencyContactText>Insolvency Service Contact Details</InsolvencyContactText><InsolvencyContact><CaseNoContact>365896321</CaseNoContact><InsolvencyServiceOffice>North West</InsolvencyServiceOffice><Contact>Enquiry Desk</Contact><ContactAddress>PO Box 16649, BIRMINGHAM, United Kingdom</ContactAddress><ContactPostCode>B2 2PB</ContactPostCode><ContactTelephone>0300 678 0016</ContactTelephone></InsolvencyContact></ReportRequest>");

            using (Stream r = new FileStream("..\\..\\..\\..\\INSS.EIIR.StubbedTestData\\searchdata.json", FileMode.Open))
            {
                await foreach (var record in JsonSerializer.DeserializeAsyncEnumerable<IndividualSearch>(r))
                {
                    var iirModel = mapper.Map<CaseResult, InsolventIndividualRegisterModel>(mapper.Map<IndividualSearch, CaseResult>(record));

                    string expectResult;
                    if (expectedresults.TryGetValue(iirModel.caseNo, out expectResult))
                        yield return new object[] {iirModel, expectResult};
                }
            }
        }

        public static IEnumerable<object[]> GetEiirBktXmlWriterData()
        {
            return GetEiirXmlWriterData().Where(x => ((InsolventIndividualRegisterModel)x[0]).RecordType == IIRRecordType.BKT);
        }



    }
}
