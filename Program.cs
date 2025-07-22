using System;
using System.Security.Cryptography.X509Certificates;
using Treinos_POO;

namespace TreinoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Endereco end = new Endereco("Rua do Programador", "2", "Centro", "Rio de Janeiro", "RJ", "89000-000");

            Pessoa joao = new Pessoa("Joao Lucas", "15/06/1990", "111.222.333-44", end);

            joao.ExibirDadosPessoais();











        }
    }
}