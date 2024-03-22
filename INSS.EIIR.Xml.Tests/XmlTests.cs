using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NuGet.Frameworks;
using Org.XmlUnit;
using Org.XmlUnit.Builder;
using Org.XmlUnit.Diff;
using System.IO;

namespace INSS.EIIR.Xml.Tests
{
    public class XmlTests
    {
        const string differences_file_path = "differences.txt";

        /// <summary>
        /// put your XML in the test-data folder. Run the test, you will hopefully not see a differences file in the bin/Debug/net6.0 folder 
        /// and the assert will pass
        /// </summary>
        [Fact]
        public void Xml_extracts_are_equal()
        {
            
            ISource control = Input.FromFile("../../../test-data/old.xml").Build();
            ISource test = Input.FromFile("../../../test-data/new.xml").Build();
            IDifferenceEngine diff = new DOMDifferenceEngine();

            bool foundDifference = false;
            diff.DifferenceListener += (comparison, outcome) => {
                foundDifference = true;
                using (var file = File.Open(differences_file_path, FileMode.Append))
                using (var stream = new StreamWriter(file))
                    stream.WriteLine(comparison.ToString());
            };
            
            diff.Compare(control, test);

            Assert.False(foundDifference);
        }
    }
}