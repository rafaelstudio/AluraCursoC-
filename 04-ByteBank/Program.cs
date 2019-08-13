using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();
            ContaCorrente contaGabriela = new ContaCorrente();

            contaBruno.titular = "BRUNO";

            Console.WriteLine(contaBruno.saldo);
            bool resultadosaque = contaBruno.Sacar(500);
            Console.WriteLine(resultadosaque);
            Console.WriteLine(contaBruno.saldo);
           

            contaBruno.Depositar(500);
            Console.WriteLine("Novo saldo :" + contaBruno.saldo);

            contaBruno.Transferir(200, contaGabriela);
            Console.WriteLine("saldo Transferencia :" + contaBruno.saldo);
            Console.WriteLine("saldo Transferencia :" + contaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
