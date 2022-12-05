using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ2_final.Entidades
{
    internal class ContratoPessoaJuridica : Contrato
    {
        public string CNPJ { get; set; }
        public int InscricaoEstadualEmpresa { get; set; }

        public ContratoPessoaJuridica()
        {

        }

        public ContratoPessoaJuridica(int numero, string contratante, double valor, int prazo, string cnpj, int inscricaoestadualempresa) : base(numero, contratante, valor, prazo)
        {
            CNPJ = cnpj;
            InscricaoEstadualEmpresa = inscricaoestadualempresa;
        }

        public override double CalcularPrestacao()
        {

            return base.CalcularPrestacao() + (3 * Prazo);
        }

        public override void ExibirInfo()
        {
            Console.WriteLine("Valor do contrato: R$" + Valor.ToString("F2") + " Prazo: " + Prazo + " Meses " + "Prestação: " + CalcularPrestacao().ToString("F2"));
        }
    }
}
    


    

