using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int opçoes;
            caminhao[] caminhao = new caminhao[200];
            carro[] carro = new carro[300];
            int cadCarros = 0;
            int cadCaminhao = 0;

            do
            {
                //MENU PRINCIPAL------------------------------------------------------------------

                Console.WriteLine(" 1- Cadastro de Carro:");
                Console.WriteLine();
                Console.WriteLine(" 2- Cadastro de Caminhão:");
                Console.WriteLine();
                Console.WriteLine(" 3- Consultar por Placa:");
                Console.WriteLine();
                Console.WriteLine(" 4- Consultar Caminhão do Modelo/Marca:");
                Console.WriteLine();
                Console.WriteLine(" 5- Consultar carro por cor:");
                Console.WriteLine();
                Console.WriteLine(" 6- Exibir todos os carros cadastrados:");
                Console.WriteLine();
                Console.WriteLine(" 7- Exibir todos os caminhões cadastrados:");
                Console.WriteLine();
                Console.WriteLine(" 0- Sair");
                opçoes = int.Parse(Console.ReadLine());



                if (opçoes != 1 && opçoes != 2 && opçoes != 3 && opçoes != 4 && opçoes != 5 && opçoes != 6 && opçoes != 7 && opçoes != 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("======Comando inválido======");
                    Console.WriteLine();
                    Console.ReadKey();
                }
                switch (opçoes)
                {
                    //CADASTRO DE CARRO------------------------------------------------------------------
                    case 1:
                        Console.Clear();


                        carro[cadCarros] = new carro();
                        Console.WriteLine();
                        Console.WriteLine("----------CADASTRO DE CARROS:-------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Modelo:-----------------");
                        carro[cadCarros].Modelo = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------Ano-------------------");
                        carro[cadCarros].Ano = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------Cor-------------------");
                        carro[cadCarros].Cor = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Fabricante:-----------------");
                        carro[cadCarros].Fabricante = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Número de Portas:-----------------");
                        carro[cadCarros].Numero_portas = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Número de Placa:-----------------");
                        carro[cadCarros].Numero_placa = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Capacidade Porta Malas:-----------------");
                        carro[cadCarros].Capacidade_porta_mala = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Bagageiro:-----------------");
                        carro[cadCarros].Bagageiro = Console.ReadLine().ToUpper()=="SIM"?true:false;
                        Console.WriteLine();
                        Console.WriteLine("--------------Automático:-----------------");
                        carro[cadCarros].Automatico = Console.ReadLine().ToUpper() == "SIM"?true:false;

                        Console.Clear();

                        cadCarros++;
                        break;

                        // CADASTRO DE CAMINHÃO---------------------------------------------------
                    case 2:
                        Console.Clear();


                        caminhao[cadCaminhao] = new caminhao();
                        Console.WriteLine();
                        Console.WriteLine("----------CADASTRO DE CAMINHÕES:-------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Modelo:-----------------");
                        caminhao[cadCaminhao].Modelo = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------Ano-------------------");
                        caminhao[cadCaminhao].Ano = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------Cor-------------------");
                        caminhao[cadCaminhao].Cor = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Fabricante:-----------------");
                        caminhao[cadCaminhao].Fabricante = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Número de Portas:-----------------");
                        caminhao[cadCaminhao].Numero_portas = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Número de Placa:-----------------");
                        caminhao[cadCaminhao].Numero_placa = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Número de Eixos:-----------------");
                        caminhao[cadCaminhao].Numero_eixos = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Peso Máximo de Carga:-----------------");
                        caminhao[cadCaminhao].Peso_maximo_carga = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------Tipo de Carga:-----------------");
                        caminhao[cadCaminhao].Tipo_de_Carga = (Console.ReadLine());

                        Console.Clear();

                        cadCaminhao++;
                        break;

                        //PESQUISA POR PLACA-------------------------------------------------------------------------
                    case 3:

                        int semCad = 0;
                        int contadorCarro = 0;
                        int contadorCaminhao = 0;
                        string placaSelecionadaCarro;
                        int opçao2;
                        string placaSelecionadaCaminhao;
                        

                        Console.Clear();

                        Console.WriteLine("----------Consulta por Placa:-----------");
                        Console.WriteLine();
                        Console.WriteLine("----------Qual voce quer pesquisar:-----------");
                        Console.WriteLine("\n1 - Carro");
                        Console.WriteLine("\n2 - Caminhão");
                        Console.WriteLine("");
                        opçao2 = int.Parse(Console.ReadLine());
                        if(opçao2 == 1)
                        {

                            Console.WriteLine("----------Digite a Placa do Carro--------------");
                            placaSelecionadaCarro = Console.ReadLine();
                            Console.Clear();

                            for (contadorCarro = 0; contadorCarro < cadCarros; contadorCarro++)
                            {
                                if (carro[contadorCarro].Numero_placa == placaSelecionadaCarro)
                                {
                                    Console.WriteLine("\t\tMODELO:{0}", carro[contadorCarro].Modelo);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tANO:{0}", carro[contadorCarro].Ano);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tCOR:{0}", carro[contadorCarro].Cor);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tFABRICANTE:{0}", carro[contadorCarro].Fabricante);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tNUMERO DE PORTAS:{0}", carro[contadorCarro].Numero_portas);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tNUMERO DE PLACA:{0}", carro[contadorCarro].Numero_placa);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tCAPACIDADE PORTA MALAS:{0}", carro[contadorCarro].Capacidade_porta_mala);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tBAGAGEIRO:{0}", carro[contadorCarro].Bagageiro==true?"SIM":"NÃO");
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tAUTOMATICO:{0}", carro[contadorCarro].Automatico==true?"SIM":"NÃO");
                                    Console.WriteLine();



                                    semCad++;

                                    Console.WriteLine("\t\t-----------------------------------------");
                                    Console.ReadKey();
                                }
                            }

                            if (semCad == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("----------------NAO HÁ CADASTROS!----------------");
                                Console.ReadKey();

                            }

                        }
                        else if(opçao2 == 2)
                        {
                            Console.WriteLine("----------Digite a Placa do Caminhão--------------");
                            placaSelecionadaCaminhao = Console.ReadLine();
                            Console.Clear();

                            for (contadorCaminhao = 0; contadorCaminhao < cadCarros; contadorCaminhao++)
                            {
                                if (caminhao[contadorCaminhao].Numero_placa == placaSelecionadaCaminhao)
                                {
                                    Console.WriteLine("\t\tMODELO:{0}", caminhao[contadorCaminhao].Modelo);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tCOR:{0}", caminhao[contadorCaminhao].Cor);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tANO:{0}", caminhao[contadorCaminhao].Ano);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tFABRICANTE:{0}", caminhao[contadorCaminhao].Fabricante);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tNUMERO DE PORTAS:{0}", caminhao[contadorCaminhao].Numero_portas);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tNUMERO DE PLACA:{0}", caminhao[contadorCaminhao].Numero_placa);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tNUMERO DE EIXOS:{0}", caminhao[contadorCaminhao].Numero_eixos);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tPESO MAXIMO DE CARGA:{0}", caminhao[contadorCaminhao].Peso_maximo_carga);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tTIPO DE CARGA:{0}", caminhao[contadorCaminhao].Tipo_de_Carga);
                                    Console.WriteLine();


                                    semCad++;

                                    Console.WriteLine("\t\t-----------------------------------------");
                                    Console.ReadKey();
                                }
                                if (contadorCarro == 200)
                                {
                                    break;
                                  
                                }
                            }

                            if (semCad == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("----------------NAO HÁ CADASTROS!----------------");
                                Console.ReadKey();

                            }

                        }

                       
                        

                        Console.ReadKey();

                        Console.Clear();
                        break;

                        // PESQUISA POR MODELO DE CAMINHAO------------------------------------------------------------------
                    case 4:

                        string modeloCaminhao;
                        int contador2;
                        int semCad2 = 0;
                

                      
                            Console.Clear();

                            Console.WriteLine("----------Consulta por Modelo :-----------");
                            Console.WriteLine();
                            Console.WriteLine("----------Digite o Modelo--------------");
                            modeloCaminhao = Console.ReadLine();

                            Console.Clear();

                            for (contador2 = 0; contador2 < cadCarros; contador2++)
                            {
                                if (caminhao[contador2].Modelo == modeloCaminhao)
                                {
                                    Console.WriteLine("\t\tMODELO:{0}", caminhao[contador2].Modelo);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tANO:{0}", caminhao[contador2].Ano);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tCOR:{0}", caminhao[contador2].Cor);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tFABRICANTE:{0}", caminhao[contador2].Fabricante);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tNUMERO DE PORTAS:{0}", caminhao[contador2].Numero_portas);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tNUMERO DE PLACA:{0}", caminhao[contador2].Numero_placa);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tNUMERO DE EIXOS:{0}", caminhao[contador2].Numero_eixos);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tPESO MAXIMO DE CARGA:{0}", caminhao[contador2].Peso_maximo_carga);
                                    Console.WriteLine();
                                    Console.WriteLine("\t\tTIPO DE CARGA:{0}", caminhao[contador2].Tipo_de_Carga);
                                    Console.WriteLine();
                                    semCad2++;

                                    Console.WriteLine("\t\t-----------------------------------------");

                                }

                            }

                            if (semCad2 == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("----------------NAO HÁ CADASTROS!----------------");
                                Console.ReadKey();

                            }
                        
                        Console.ReadKey();

                        Console.Clear();

                            break;
                       
                        // CONSULTAR CARRO POR COR -----------------------------------------------------------------------
                            case 5:
                        string consultaCor;
                        int contador3;
                        int semCad3 = 0;



                        Console.Clear();

                        Console.WriteLine("----------Consulta por Cor :-----------");
                        Console.WriteLine();
                        Console.WriteLine("----------Digite a Cor do Carro--------------");
                        consultaCor = Console.ReadLine();

                        Console.Clear();

                        for (contador3 = 0; contador3 < cadCarros; contador3++)
                        {
                            if (carro[contador3].Cor == consultaCor)
                            {
                                Console.WriteLine("\t\tMODELO:{0}", carro[contador3].Modelo);
                                Console.WriteLine();
                                Console.WriteLine("\t\tANO:{0}", carro[contador3].Ano);
                                Console.WriteLine();
                                Console.WriteLine("\t\tCOR:{0}", carro[contador3].Cor);
                                Console.WriteLine();
                                Console.WriteLine("\t\tFABRICANTE:{0}", carro[contador3].Fabricante);
                                Console.WriteLine();
                                Console.WriteLine("\t\tNUMERO DE PORTAS:{0}", carro[contador3].Numero_portas);
                                Console.WriteLine();
                                Console.WriteLine("\t\tNUMERO DE PLACA:{0}", carro[contador3].Numero_placa);
                                Console.WriteLine();
                                Console.WriteLine("\t\tCAPACIDADE PORTA MALAS:{0}", carro[contador3].Capacidade_porta_mala);
                                Console.WriteLine();
                                Console.WriteLine("\t\tBAGAGEIRO:{0}", carro[contador3].Bagageiro == true ? "SIM" : "NÃO");
                                Console.WriteLine();
                                Console.WriteLine("\t\tAUTOMATICO:{0}", carro[contador3].Automatico == true ? "SIM" : "NÃO");
                                Console.WriteLine();
                                semCad3++;

                                Console.WriteLine("\t\t-----------------------------------------");

                            }

                        }

                        if (semCad3 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("----------------NAO HÁ CADASTROS!----------------");
                            Console.ReadKey();

                        }

                        Console.ReadKey();

                        Console.Clear();

                        break;

                        //EXIBIR TODOS OS CARROS CADASTRADOS----------------------------------------------------------------------
                    case 6:

                        int contador4;
                        int semCad4 = 0;

                        Console.Clear();

                        Console.WriteLine("----------Consultar Todos os carros cadastrados:-----------");
                        Console.WriteLine();


                        Console.Clear();

                        for (contador4 = 0; contador4 < cadCarros; contador4++)
                        {

                            Console.WriteLine("\t\tMODELO:{0}", carro[contador4].Modelo);
                            Console.WriteLine();
                            Console.WriteLine("\t\tANO:{0}", carro[contador4].Ano);
                            Console.WriteLine();
                            Console.WriteLine("\t\tCOR:{0}", carro[contador4].Cor);
                            Console.WriteLine();
                            Console.WriteLine("\t\tFABRICANTE:{0}", carro[contador4].Fabricante);
                            Console.WriteLine();
                            Console.WriteLine("\t\tNUMERO DE PORTAS:{0}", carro[contador4].Numero_portas);
                            Console.WriteLine();
                            Console.WriteLine("\t\tNUMERO DE PLACA:{0}", carro[contador4].Numero_placa);
                            Console.WriteLine();
                            Console.WriteLine("\t\tCAPACIDADE PORTA MALAS:{0}", carro[contador4].Capacidade_porta_mala);
                            Console.WriteLine();
                            Console.WriteLine("\t\tBAGAGEIRO:{0}", carro[contador4].Bagageiro == true ? "SIM" : "NÃO");
                            Console.WriteLine();
                            Console.WriteLine("\t\tAUTOMATICO:{0}", carro[contador4].Automatico == true ? "SIM" : "NÃO");
                            Console.WriteLine();

                            semCad4++;

                                Console.WriteLine("\t\t-----------------------------------------");
                         }


                        if (semCad4 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("----------------NAO HÁ CADASTROS!----------------");
                            Console.ReadKey();

                        }

                        Console.ReadKey();

                        Console.Clear();
                        break;

                        //EXIBIR TODOS OS CAMINHÕES CADASTRADOS-------------------------------------------------------------------
                    case 7:
                        int contador5;
                        int semCad5 = 0;

                        Console.Clear();

                        Console.WriteLine("----------Consultar Todos os caminhões cadastrados:-----------");
                        Console.WriteLine();


                        Console.Clear();

                        for (contador5 = 0; contador5 < cadCaminhao; contador5++)
                        {


                            Console.WriteLine("\t\tMODELO:{0}", caminhao[contador5].Modelo);
                            Console.WriteLine();
                            Console.WriteLine("\t\tANO:{0}", caminhao[contador5].Ano);
                            Console.WriteLine();
                            Console.WriteLine("\t\tCOR:{0}", caminhao[contador5].Cor);
                            Console.WriteLine();
                            Console.WriteLine("\t\tFABRICANTE:{0}", caminhao[contador5].Fabricante);
                            Console.WriteLine();
                            Console.WriteLine("\t\tNUMERO DE PORTAS:{0}", caminhao[contador5].Numero_portas);
                            Console.WriteLine();
                            Console.WriteLine("\t\tNUMERO DE PLACA:{0}", caminhao[contador5].Numero_placa);
                            Console.WriteLine();
                            Console.WriteLine("\t\tNUMERO DE EIXOS:{0}", caminhao[contador5].Numero_eixos);
                            Console.WriteLine();
                            Console.WriteLine("\t\tPESO MAXIMO DE CARGA:{0}", caminhao[contador5].Peso_maximo_carga);
                            Console.WriteLine();
                            Console.WriteLine("\t\tTIPO DE CARGA:{0}", caminhao[contador5].Tipo_de_Carga);
                            Console.WriteLine();

                            semCad5++;

                            Console.WriteLine("\t\t-----------------------------------------");
                        }


                        if (semCad5 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("----------------NAO HÁ CADASTROS!----------------");
                            Console.ReadKey();

                        }

                        Console.ReadKey();

                        Console.Clear();


                        break;


                }
            } while (opçoes != 0);
        }
    }
}