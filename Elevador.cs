using System;
using System.Collections.Generic;
namespace even3
{
    public class Elevador
    {

        public List<Passageiro> _passageiros = new List<Passageiro>();
        
        public List<Passageiro> _passageirosNoElevador = new List<Passageiro>();
        public Elevador(){}

        int quantidadeTotal = 0;
        public Elevador(List<Passageiro> l , int andarAtual)
        {
            _passageiros = l;
            _andarAtual = andarAtual;
            quantidadeTotal = _passageiros.Count;
        } 
        
        private int _andarAtual;
        public int AndarAtual
        {
            get { return _andarAtual;}
            set { _andarAtual = value;}
        }
        
        public void ir(int destino)
        {
            int mult = _andarAtual > destino ? -1 : 1;

            System.Console.WriteLine( string.Format("origem : {0} , destino : {1}",_andarAtual,destino));
            while(_andarAtual != destino)
            {
                _andarAtual += mult;
                Console.WriteLine(_andarAtual);
            }            
        }


        

        private void pegarLevar(Passageiro p)
        {
            ir(p.Origem);
            ir(p.Destino);
            quantidadeTotal += -1;
            
        }

        public void elevadorBurro()
        {
            foreach (Passageiro item in _passageiros)
            {
                pegarLevar(item);
            }

            _passageiros.Clear();
        } 


    }
}
