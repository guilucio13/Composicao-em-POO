using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Treinos_POO
{
    internal class Endereco
    {
        //Propriedas
       public string Rua {  get; set; }
       public string Numero{ get; set; }
       public string Bairro { get; set; }
       public string Cidade { get; set; }
       public string Estado { get; set; }
       public string CEP { get; private set; }

        //Construtor
        public Endereco (string rua, string numero, string bairro, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }

        // Métodos 
        public void ExibirEndereçoCompleto()
        {
           Console.WriteLine($"{Rua}, {Numero} - {Bairro}, {Cidade} - {Estado}, CEP: {CEP}");
        }


    
        













    }
}
