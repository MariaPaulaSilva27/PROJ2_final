using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace PROJ2_final.Entidades
{
    internal class ContratoPessoaFisica : Contrato
    {
        public string CPF { get; set; }
        public int IdadeContratante { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAtual { get; set; }

        public ContratoPessoaFisica()
        {

        }

        public ContratoPessoaFisica(int numero, string contratante, double valor, int prazo, string cpf, int idadecontratante, DateTime datanascimento, DateTime dataatual) : base(numero, contratante, valor, prazo)
        {
            CPF = cpf;
            IdadeContratante = idadecontratante;
            DataNascimento = datanascimento;
            DataAtual = dataatual;
        }
        public int CalcularIdade(DateTime DataNascimento, DateTime DataAtual)
        {
            IdadeContratante = DataAtual.Year - DataNascimento.Year;
            return IdadeContratante;
        }

        public override double CalcularPrestacao()
        {
             
            if (IdadeContratante <= 30)
            {
                return Valor + 1;
            }
            else if (IdadeContratante <= 40)
            {
                return Valor + 2;
            }
            else if (IdadeContratante <= 50)
            {
                return Valor + 3;
            }
            else if (IdadeContratante > 50)
            {
                return Valor + 4;
            }
            return (IdadeContratante);
        }
    }

    public override void ExibirInfo()
    {
        Console.WriteLine("Valor do contrato: R$" + Valor.ToString("F2") + " Prazo: " + Prazo + " Meses // Prestação: " + CalcularPrestacao().ToString("F2"));
    }

    //Erros:  método exibir info e variáveis dentro do método não encontradas nele.
}



