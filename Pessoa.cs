using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Treinos_POO
{
    internal class Pessoa
    {
        //Propriedades
         public string Nome { get; set; }
         public string DataNascimento { get; private set; }
         public string CPF { get; private set; }
         public Endereco EnderecoResidencial { get; set; }

        //Construtor 
        public Pessoa(string nome, string dataNascimento, string cpf, Endereco enderecoResidencial)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            EnderecoResidencial  = enderecoResidencial;
            
        }
        
        //Método
        public void ExibirDadosPessoais()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"DataNascimento: {DataNascimento}");
            Console.WriteLine($"CPF: {CPF}");
            Console.Write($"Endereço: ");
            EnderecoResidencial.ExibirEndereçoCompleto();
        }






    }
}
