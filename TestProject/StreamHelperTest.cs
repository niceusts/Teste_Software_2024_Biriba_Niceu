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
            string input = "a,b \n c,d";
            var expected = Encoding.UTF8.GetBytes(input);

            // Act
            using (var stream = StreamHelper.GenerateStreamFromString(input))
            {
                // Assert
                using (var reader = new BinaryReader(stream))
                {
                    byte[] result = reader.ReadBytes((int)stream.Length);
                    CollectionAssert.AreEqual(expected, result);
                }
            }
        }
    }
}