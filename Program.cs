using System;
using System.Collections.Generic;

namespace even3
{
    class Program
    {
        static void Main(string[] args)
        {
            int andares = 10;

            List<Passageiro> passageiros = new List<Passageiro>();
          
            passageiros.Add(new Passageiro(8,1));
            passageiros.Add(new Passageiro(1,10));

            Elevador elevador = new Elevador(passageiros,5);

            elevador.elevadorBurro();

        }
    }
}
