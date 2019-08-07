using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    class carro: veiculo
    {
        private string capacidade_porta_mala;
        private bool bagageiro;
        private bool automatico;

        //construtor sem parâmetros

        public carro()
        {
            this.capacidade_porta_mala = null;
            this.bagageiro = false;
            this.automatico = false;
        }

        public carro(string capacidade_porta_mala , bool bagageiro, bool automatico)
        {
            this.capacidade_porta_mala = capacidade_porta_mala;
            this.bagageiro = bagageiro;
            this.automatico = automatico;
        }

        public string Capacidade_porta_mala
        {
            get { return capacidade_porta_mala; }
            set { capacidade_porta_mala = value; }
        }

        public bool Bagageiro
        {
            get { return bagageiro; }
            set { bagageiro = value; }
        }

        public bool Automatico
        {
            get { return automatico; }
            set { automatico = value; }
        }
    }
}
