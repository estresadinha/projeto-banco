using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta1= new ContaCorrente();
            ContaCorrente conta2= new ContaCorrente();
            conta1.agencia = 50;
            conta1.conta = "123";
            conta1.nome = "manu";
            conta1.saldo = 400;
            

            conta2.agencia = 20;
            conta2.conta = "122";
            conta2.nome = "Mel";
            conta2.saldo = 300;

            
            
           // Console.WriteLine("o saldo da conta é "+ conta1.saldo);
           // Console.WriteLine("Meu nome é "+ conta1.nome);
           // Console.WriteLine("Minha agencia é " + conta1.agencia);
           // Console.WriteLine("minha conta é " + conta1.conta);
           // Console.WriteLine("o saldo anterior é: " + conta1.saldo);
           // conta1.Depositar(200);
           // Console.WriteLine("o saldo depois do deposito é " + conta1.saldo);

           // Console.WriteLine("o saldo anterior é "+ conta2.saldo);
          // if(conta2.sacar(100))
            
            //Console.WriteLine("o saldo atual é " + conta2.saldo) ;

            
                Console.WriteLine("o saldo atual da conta que ira transferir " + conta1.saldo );
            Console.WriteLine("o saldo da conta que ira receber " + conta2.saldo);

            if (conta1.Transferir(100, conta2))

                Console.WriteLine("o valor da sua transderencia é " + conta1.valort);

            Console.WriteLine(" o saldo atual após voce transferir é " + conta1.saldo);
            Console.WriteLine("saldo atual após receber " + conta2.saldo);


            { 
            }



            






        }
    }
}
