using Bytebank.Contas;
using Bytebank.Titular;
using System;

//ContaCorrente conta = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1010-H";
//conta3.SetSaldo(500);
//Console.WriteLine("Seu saldo é: R$ " +conta3.Getsaldo());
//Console.WriteLine("Nº de Agência: " +conta3.Numero_agencia);
//Console.WriteLine("Conta: " +conta3.Conta);


ContaCorrente conta2 = new ContaCorrente(18, "1010-X");
conta2.SetSaldo(500);
conta2.Titular = new Cliente();

Console.WriteLine(conta2.Getsaldo());
Console.WriteLine(conta2.Numero_agencia);