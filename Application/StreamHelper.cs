using System.Text;

namespace Teste_Software_2024_Biriba_Niceu
{
    public static class StreamHelper
    {
        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0; // Reposiciona o stream para o início
            return stream;
        }
    }
}