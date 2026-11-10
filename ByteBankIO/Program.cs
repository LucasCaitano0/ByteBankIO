using ByteBankIO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;




            var buffer = new byte[1024]; // 1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            // public override int Read(byte[] array, int offset, int count);
            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
            
    }

    static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer);
        Console.Write(texto);

        /*
        foreach (var meuByte in buffer)
        {
            Console.Write($"{meuByte} ");
        }*/
    }
}