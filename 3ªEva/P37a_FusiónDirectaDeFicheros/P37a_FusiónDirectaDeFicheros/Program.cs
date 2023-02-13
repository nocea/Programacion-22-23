﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace P37a_FusionDirectaDeFicheros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abrimos los dos ficheros existentes.
            StreamReader streamReader1 = File.OpenText(@".\Datos\n1.txt");
            StreamReader streamReader2 = File.OpenText(@".\Datos\n2.txt");

            //Creamos un nuevo fichero para guardarlo
            StreamWriter streamWriter = File.CreateText(@".\Datos\n3.txt");

            int numPar = 0;
            int numImpar = 0;
            Boolean primeraVez = true;
            Boolean ultimoPar = false;
            Boolean ultimoImpar = false;
            Boolean existioUltimoImpar = false;
            Boolean existioUltimoPar = false;
            Boolean pintoPar = false;
            Boolean pintoImpar = false;

            //Recorremos los dos ficheros con los impares.
            while (!streamReader1.EndOfStream || !streamReader2.EndOfStream)
            {
                if (!primeraVez)
                {
                    if (numPar < numImpar)
                    {
                        if (!streamReader2.EndOfStream)
                        {
                            numPar = Convert.ToInt32(streamReader2.ReadLine());
                            if (streamReader2.EndOfStream)
                            {
                                ultimoPar = true;
                                existioUltimoPar = true;
                            }
                        }
                        else if (streamReader2.EndOfStream && !streamReader1.EndOfStream && pintoPar)
                        {
                            pintoPar = false;

                            Console.WriteLine(numImpar);
                            streamWriter.WriteLine(numImpar);

                            numImpar = Convert.ToInt32(streamReader1.ReadLine());
                        }
                        else if (streamReader2.EndOfStream && !streamReader1.EndOfStream)
                        {
                            numImpar = Convert.ToInt32(streamReader1.ReadLine());
                        }

                    }
                    else
                    {
                        if (!streamReader1.EndOfStream)
                        {
                            numImpar = Convert.ToInt32(streamReader1.ReadLine());
                            if (streamReader1.EndOfStream)
                            {
                                ultimoImpar = true;
                                existioUltimoImpar = true;
                            }
                        }
                        else if (streamReader1.EndOfStream && !streamReader2.EndOfStream && pintoImpar)
                        {
                            pintoImpar = false;

                            Console.WriteLine(numPar);
                            streamWriter.WriteLine(numPar);

                            numPar = Convert.ToInt32(streamReader2.ReadLine());
                        }
                        else if (streamReader1.EndOfStream && !streamReader2.EndOfStream)
                        {
                            numPar = Convert.ToInt32(streamReader2.ReadLine());
                        }

                    }

                }
                else
                {
                    numImpar = Convert.ToInt32(streamReader1.ReadLine());
                    numPar = Convert.ToInt32(streamReader2.ReadLine());
                    primeraVez = false;
                }

                if (numPar < numImpar)
                {
                    if (!streamReader2.EndOfStream)
                    {
                        Console.WriteLine(numPar);
                        streamWriter.WriteLine(numPar);

                        pintoPar = true;
                        pintoImpar = false;
                    }
                    else if (ultimoPar)
                    {
                        Console.WriteLine("lo voy a probar" + numPar);
                        streamWriter.WriteLine(numPar);

                        ultimoPar = false;

                        pintoPar = true;
                        pintoImpar = false;
                    }
                    else if (!streamReader1.EndOfStream)
                    {
                        Console.WriteLine(numImpar);
                        streamWriter.WriteLine(numImpar);

                        pintoPar = false;
                        pintoImpar = true;

                    }

                }
                else
                {
                    if (!streamReader1.EndOfStream)
                    {
                        Console.WriteLine(numImpar);
                        streamWriter.WriteLine(numImpar);

                        pintoPar = false;
                        pintoImpar = true;
                    }
                    else if (ultimoImpar)
                    {
                        Console.WriteLine(numImpar);
                        streamWriter.WriteLine(numImpar);
                        ultimoImpar = false;

                        pintoPar = false;
                        pintoImpar = true;
                    }
                    else if (!streamReader2.EndOfStream)
                    {
                        Console.WriteLine(numPar);
                        streamWriter.WriteLine(numPar);

                        pintoPar = true;
                        pintoImpar = false;
                    }

                }
            }
            if (existioUltimoImpar)
            {
                //esto significa que nunca llego a true ultimoPar
                Console.WriteLine(numPar);
                streamWriter.WriteLine(numPar);

            }
            else if (existioUltimoPar)
            {
                Console.WriteLine(numImpar);
                streamWriter.WriteLine(numImpar);
            }

            streamReader1.Close();
            streamReader2.Close();
            streamWriter.Close();









        }
    }
}