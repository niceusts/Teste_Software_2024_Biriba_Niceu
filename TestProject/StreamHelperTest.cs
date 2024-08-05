using Teste_Software_2024_Biriba_Niceu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace Teste_Software_2024_Biriba_Niceu.Tests
{
    [TestClass]
    public class StreamHelperTests
    {
        [TestMethod]
        public void GenerateStreamFromString_ShouldReturnStreamContainingInputString()
        {
            // Arrange
            string inputString = "a,b\nc,d";
            Stream expectedStream = new MemoryStream(Encoding.UTF8.GetBytes(inputString));

            // Act
            Stream actualStream = StreamHelper.GenerateStreamFromString(inputString);

            // Assert
            using (StreamReader expectedReader = new StreamReader(expectedStream))
            using (StreamReader actualReader = new StreamReader(actualStream))
            {
                string expectedContent = expectedReader.ReadToEnd();
                string actualContent = actualReader.ReadToEnd();

                Assert.AreEqual(expectedContent, actualContent);
            }
        }
    }
}
