using System;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha)
        {
            if (usuario.Autenticar(senha))
            {
                Console.WriteLine("Entrada no sistema realizada");
                return true;
            }

            Console.WriteLine("Não foi possível logar no sistema");
            return false;
        }
    }
}
