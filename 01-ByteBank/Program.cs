﻿using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 853;
            contaDaGabriela.numero  = 863452;
            contaDaGabriela.saldo   = 100;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia :" + contaDaGabriela.agencia);
            Console.WriteLine("Numero Conta: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);
            contaDaGabriela.saldo += 200;
            Console.WriteLine("Novo Saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
            
        }
    }
}
