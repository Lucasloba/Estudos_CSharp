using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePix;
using bytebank_Modelos_.bytebank.Modelos.ADM.Utilitario;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento." + "\n");
//new ByteBankAtendimento().AtendimentoCliente();

Console.WriteLine(GeradorPix.GetChavePix());

var listaDeChaves = GeradorPix.GetChavesPix(10);

foreach (var chave in listaDeChaves)
{
    Console.WriteLine(chave);
}




