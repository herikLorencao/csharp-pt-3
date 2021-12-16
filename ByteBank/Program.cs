using ByteBank.Funcionarios;
using ByteBank.Parceiros;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();
            UsarSistemaInterno();
            Console.ReadLine();
        }

        public static void UsarSistemaInterno()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            GerenteDeConta gerenteDeConta = new GerenteDeConta("710.412.000-99");
            gerenteDeConta.Nome = "Ana";
            gerenteDeConta.Senha = "123";

            Diretor diretor = new Diretor("493.614.060-00");
            diretor.Nome = "Carla";
            diretor.Senha = "456";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "abc";

            sistemaInterno.Logar(gerenteDeConta, "123");
            sistemaInterno.Logar(diretor, "456");
            sistemaInterno.Logar(parceiroComercial, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Auxiliar auxiliar = new Auxiliar("837.274.310-08");
            auxiliar.Nome = "João";

            Designer designer = new Designer("970.069.270-13");
            designer.Nome = "Pedro";

            GerenteDeConta gerenteDeConta = new GerenteDeConta("710.412.000-99");
            gerenteDeConta.Nome = "Ana";

            Diretor diretor = new Diretor("493.614.060-00");
            diretor.Nome = "Carla";

            gerenciadorBonificacao.Registrar(auxiliar);
            gerenciadorBonificacao.Registrar(designer);
            gerenciadorBonificacao.Registrar(gerenteDeConta);
            gerenciadorBonificacao.Registrar(diretor);

            Console.WriteLine(gerenciadorBonificacao.getTotalBonificacao());
        }
    }
}