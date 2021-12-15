using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario funcionario = new Funcionario("125.246.146-12");
            funcionario.Nome = "João";
            funcionario.Salario = 1000;

            gerenciadorBonificacao.Registrar(funcionario);

            Diretor diretor = new Diretor("122.456.125-12");
            diretor.Nome = "Roberta";
            diretor.Salario = 5000;

            gerenciadorBonificacao.Registrar(diretor);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());

            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.GetBonificacao());

            Console.WriteLine("Total da bonificação: " + gerenciadorBonificacao.getTotalBonificacao());

            Console.ReadLine();
        }
    }
}