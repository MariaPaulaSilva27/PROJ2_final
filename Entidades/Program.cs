

using System;
using System.Globalization;
using System.Collections.Generic;

namespace PROJ2_final.Entidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> list = new List<Contrato>();



            Console.Write("O contrato é de pessoa física ou de pessoa jurídica (F/J)? ");
            char Ch = char.Parse(Console.ReadLine());
            Console.Write("Número do contrato: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do contratante: ");
            String Contratante = Console.ReadLine();
            Console.Write("Valor do contrato: ");
            double Valor = double.Parse(Console.ReadLine());
            Console.Write("Prazo do contrato: ");
            int Prazo = int.Parse(Console.ReadLine());

            if (Ch == 'f' || Ch == 'F')
            {
                Console.Write("CPF do contratante: ");
                string CPF = Console.ReadLine();
                Console.WriteLine("Idade do contratante: ");
                int IdadeContratante = int.Parse(Console.ReadLine());
                Console.WriteLine("Data de nascimento do contratante: ");
                DateTime DataNascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Data atual: ");
                DateTime DataAtual = DateTime.Parse(Console.ReadLine());
                list.Add(new ContratoPessoaFisica(Numero, Contratante, Valor, Prazo, CPF, IdadeContratante, DataNascimento, DataAtual));
            }



            else if (Ch == 'j' || Ch == 'J')
            {
                Console.Write("CNPJ do contratante: ");
                string CNPJ = Console.ReadLine();
                Console.WriteLine("Inscrição estadual de empresa do contratante: ");
                int InscricaoEstadualEmpresa = int.Parse(Console.ReadLine());
                list.Add(new ContratoPessoaJuridica(Numero, Contratante, Valor, Prazo, CNPJ, InscricaoEstadualEmpresa));
            }


            foreach (ContratoPessoaFisica emp in list)
            {
                Console.WriteLine(emp.CalcularPrestacao());
            }
            foreach (ContratoPessoaJuridica emp in list)
            {
                Console.WriteLine(emp.CalcularPrestacao());
            }

            
        }
    }
}
 
