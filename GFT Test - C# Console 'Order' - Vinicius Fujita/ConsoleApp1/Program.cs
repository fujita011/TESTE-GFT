using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        //Inicio 23:20 (13/01)
        static void Main(string[] args)
        {
            
            string periodo, pedido;
            string entrada, acomp, bebida, sobremesa;
            string qtde;

            // Variaveis

            Console.WriteLine("Selecione um período: ");
            Console.WriteLine("1- Manhã");
            Console.WriteLine("2- Noite");
            periodo = Console.ReadLine();
            if (periodo == "1")
            {
                Console.WriteLine("Você selecionou 'Manhã'!");
                entrada = "Ovos";
                acomp = "Torradas";
                bebida = "Café";
                sobremesa = "Erro. Não disponível.";


                //----------------------------------------------

                Console.WriteLine("Faça seu pedido!");
                Console.WriteLine();
                Console.WriteLine("1- Entrada");
                Console.WriteLine("2- Acompanhamentos");
                Console.WriteLine("3- Bebida");
                Console.WriteLine("4- Sobremesa");
                pedido = Console.ReadLine();
                switch (pedido)
                {
                    case "1":
                        {
                            Console.WriteLine("Você selecionou entrada: "+ entrada);
                            Console.WriteLine();
                            Console.WriteLine("Quantas unidades?");
                            qtde = Console.ReadLine();
                            if (qtde == "1")
                            {
                                Console.WriteLine("Você adicionou " + qtde + " de " +entrada);
                                
                            }
                            else
                            {
                                Console.WriteLine("Você pode escolher apenas 1 unidade!");
                                Console.WriteLine("Reinicie o programa!");
                                
                            }

                            break;
                        }

                    //---------------------------------------------


                    case "2":
                        {
                            if (periodo == "1")
                            {
                                Console.WriteLine("Você selecionou acompanhamentos:" +acomp);
                                Console.WriteLine();
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                if (qtde == "1")
                                {
                                    Console.WriteLine("Você adicionou " + qtde+ " de "+acomp);
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Você pode escolher apenas 1 unidade!");
                                    Console.WriteLine("Reinicie o programa!");
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Você adicionou " + qtde + " de " +acomp);
                            }
                            break;
                        }


                    //-----------------------------------------------------


                    case "3":
                        {
                            if (periodo == "2")
                            {
                                Console.WriteLine("Você selecionou bebida: " +bebida);
                                Console.WriteLine();
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                if (qtde == "1")
                                {
                                    Console.WriteLine("Você adicionou " + qtde + " de " +bebida);
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Você pode escolher apenas 1 unidade!");
                                    Console.WriteLine("Reinicie o programa!");
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Você adicionou " + qtde + " de "+bebida);
                            }
                            break;

                        }


                    //---------------------------------------------------3


                    case "4":
                        {
                            if (periodo == "1")
                            {
                                Console.WriteLine("Não é possível adicionar 'sobremesa' neste horário!");
                                
                                    
                                }
                            
                            else
                            {
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                if (qtde == "1")
                                {
                                    Console.WriteLine("Você adicionou " + qtde + " de " + sobremesa);
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Você pode escolher apenas 1 unidade!");
                                    Console.WriteLine("Reinicie o programa!");
                                    
                                }


                            }
                            break;

                        }
                }
            }

            //--------------------------------------



            else if (periodo == "2")
            {
                Console.WriteLine("Você selecionou 'Noite'!");
                entrada = "Beef";
                acomp = "Batatas";
                bebida = "Vinho";
                sobremesa = "Bolo";


                //----------------------------

                Console.WriteLine("Faça seu pedido!");
                Console.WriteLine();
                Console.WriteLine("1- Entrada");
                Console.WriteLine("2- Acompanhamentos");
                Console.WriteLine("3- Bebida");
                Console.WriteLine("4- Sobremesa");
                pedido = Console.ReadLine();


                //------------------------------------------------


                switch (pedido)
                {
                    case "1":
                        {
                            Console.WriteLine("Você selecionou entrada: " + entrada);
                            Console.WriteLine();
                            Console.WriteLine("Quantas unidades?");
                            qtde = Console.ReadLine();
                            if (qtde == "1")
                            {
                                Console.WriteLine("Você adicionou " + qtde + " de " + entrada);
                                
                            }
                            else
                            {
                                Console.WriteLine("Você pode escolher apenas 1 unidade!");
                                Console.WriteLine("Reinicie o programa!");
                                
                            }

                            break;
                        }

                    //---------------------------------------------


                    case "2":
                        {
                            if (periodo == "1")
                            {
                                Console.WriteLine("Você selecionou acompanhamentos:" + acomp);
                                Console.WriteLine();
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                if (qtde == "1")
                                {
                                    Console.WriteLine("Você adicionou " + qtde + " de " + acomp);
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Você pode escolher apenas 1 unidade!");
                                    Console.WriteLine("Reinicie o programa!");
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Você adicionou " + qtde + " de " + acomp);
                            }
                            break;
                        }


                    //-----------------------------------------------------


                    case "3":
                        {
                            if (periodo == "2")
                            {
                                Console.WriteLine("Você selecionou bebida: " + bebida);
                                Console.WriteLine();
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                if (qtde == "1")
                                {
                                    Console.WriteLine("Você adicionou " + qtde + " de " + bebida);
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Você pode escolher apenas 1 unidade!");
                                    Console.WriteLine("Reinicie o programa!");
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Você adicionou " + qtde + " de " + bebida);
                            }
                            break;

                        }


                    //---------------------------------------------------3


                    case "4":
                        {
                            if (periodo == "1")
                            {
                                Console.WriteLine("Não é possível adicionar 'sobremesa' neste horário!");

                                
                            }

                            else
                            {
                                Console.WriteLine("Quantas unidades?");
                                qtde = Console.ReadLine();
                                if (qtde == "1")
                                {
                                    Console.WriteLine("Você adicionou " + qtde + " de " + sobremesa);
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Você pode escolher apenas 1 unidade!");
                                    Console.WriteLine("Reinicie o programa!");
                                    
                                }
                                
                            }
                            break;

                        }
                }
            }











            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar!");
            Console.ReadKey();
            
        }
    }
}
