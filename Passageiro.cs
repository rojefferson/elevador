using System;

namespace even3
{
    public class Passageiro
    {

        public Passageiro(){}
        public Passageiro(int origem, int destino)
        {
            this._origem = origem;
            this._destino = destino;
        }
        private int _origem;
        public int Origem
        {
            get { return _origem;}
            set { _origem = value;}
        }
        
        private int _destino;
        public int Destino
        {
            get { return _destino;}
            set { _destino = value;}
        }
        

    }
}
