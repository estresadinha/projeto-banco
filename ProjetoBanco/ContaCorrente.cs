using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco;



public class ContaCorrente
{
    public string nome;
    public int agencia;
    public string conta;
    public double saldo;
    public double valort;
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool sacar(double valor)

    {
        if (this.saldo >= valor)
        {
          
            this.saldo -= valor;
            return true;

        }
        else
        {
            Console.WriteLine("saldo " + "insuficiente para realizar o saque ");
            return false;
        }



    }
    public bool Transferir (double valor, ContaCorrente destino)
    {
        if(this.saldo >= valor) 
        {
            valort = valor;
            this.saldo -= valor;
         destino.saldo += valor;
            return true;
        }
        else
        {
            Console.WriteLine("não é possivel realizar a transferencia  ");
            return false;
        }
         
        {

        }

    }


   
    
  
}








