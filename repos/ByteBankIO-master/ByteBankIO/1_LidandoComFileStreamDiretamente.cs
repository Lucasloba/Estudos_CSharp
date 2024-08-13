using ByteBankIO;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        // FileStream é uma classe e fluxo do arquivo é o objeto instanciado 
        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            // buffer é só uma forma de chamar o array ie determina o tamanho de bytes lidos por parte
            // buffer = byte[] array
            var buffer = new byte[1024]; // 1KB
                                         //enderecoDoArquivo.lenght
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                // pulbic override int Read(byte[] array, int offset, int conut);

                Console.WriteLine($"\n Bytes lidos: {numeroDeBytesLidos}");
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            // Devoluções? 
            // O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
            // bytes solicitado se esse número de bytes não estiver disponível no momento, ou 
            // zero, se o final do fluxo for atingido

            fluxoDoArquivo.Close();
            Console.ReadLine();
        }
    }

    //método para transformar a lista em letras
    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        //public virtual string GetString(byte[] bytes, int index, int count);
        Console.Write(texto);

        /*
        foreach(var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
        */
    }

}