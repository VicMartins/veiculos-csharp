using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    class veiculo
    {
        private string modelo;
        private string fabricante;
        private string cor;
        private int ano;
        private int numero_portas;
        private string numero_placa;

        //construtor sem parâmetros

        public veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.cor = null;
            this.ano = 0;
            this.numero_portas = 0;
            this.numero_placa = null;
        }

        public veiculo(string modelo, string fabricante, string cor, int ano, int numero_portas, string numero_placa)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.cor = cor;
            this.ano = ano;
            this.numero_portas = numero_portas;
            this.numero_placa = numero_placa;
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int Numero_portas
        {
            get { return numero_portas; }
            set { numero_portas = value; }
        }
        public string Numero_placa
        {
            get { return numero_placa; }
            set { numero_placa = value; }
        }
    }
}
