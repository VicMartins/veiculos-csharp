using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    class caminhao: veiculo
    {
        private int numero_eixos;
        private double peso_maximo_carga;
        private string tipo_de_carga;

        //construtor sem parâmetros

        public caminhao()
        {
            this.numero_eixos = 0;
            this.peso_maximo_carga = 0.0;
            this.tipo_de_carga = null;
        }

        public caminhao(int numero_eixos, double peso_maximo_carga, string tipo_de_carga)
        {
            this.tipo_de_carga = tipo_de_carga;
            this.peso_maximo_carga = peso_maximo_carga;
            this.numero_eixos = numero_eixos;

        }
        
        public int Numero_eixos
        {
            get { return numero_eixos; }
            set { numero_eixos = value; }
        }
        public double Peso_maximo_carga
        {
            get { return peso_maximo_carga; }
            set { peso_maximo_carga = value; }
        }

        public string Tipo_de_Carga
            {
            get { return tipo_de_carga; }
            set { tipo_de_carga = value; }
            }

        
    }
}
