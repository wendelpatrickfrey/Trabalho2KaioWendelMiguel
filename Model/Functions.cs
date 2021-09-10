using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model
{
    public static class Functions
    {
        public static string[][] matriz = new string[5][];

        //Gerador automatico de letras em matriz C#
        public static string[][] Gerador()
        {
            List<string> lista = new List<string>();
            Random ran = new Random();
            lista.Add("");
            lista.Add("");
            lista.Add("");
            lista.Add("");
            lista.Add("");
            lista.Add("");

            ////A e D [0] label1
            if (ran.Next(1, 3) == 1)
            {
                lista.Add("A");
            }
            else
            {
                lista.Add("D");
            }
            //E e F [1] label2
            if (ran.Next(1, 3) == 2)
            {
                lista.Add("E");
            }
            else
            {
                lista.Add("F");
            }
            //B e C [2] label3
            if (ran.Next(1, 3) == 2)
            {
                lista.Add("B");
            }
            else
            {
                lista.Add("C");
            }

            lista.Add("");
            lista.Add("");

            ///G,I,U [3] label4
            if (ran.Next(1, 3) == 2)
            {
                lista.Add("G");
            }
            else if (ran.Next(1, 3) == 2)
            {
                lista.Add("I");
            }
            else
            {
                lista.Add("U");
            }
            //H, J e V [4] label5
            if (ran.Next(1, 3) == 2)
            {
                lista.Add("H");
            }
            else if (ran.Next(1, 3) == 2)
            {
                lista.Add("J");
            }
            else
            {
                lista.Add("V");
            }
            //K e L [5] label6
            if (ran.Next(1, 3) == 2)
            {
                lista.Add("K");
            }
            else
            {
                lista.Add("L");
            }

            lista.Add("");
            lista.Add("");

            //M, O e Q [6] label7
            if (ran.Next(1, 3) == 2)
            {
                lista.Add("M");
            }
            else if (ran.Next(1, 3) == 2)
            {
                lista.Add("O");
            }
            else
            {
                lista.Add("Q");
            }
            //N, T e P [7] label8
            if (ran.Next(1, 3) == 2)
            {
                lista.Add("N");
            }
            else if (ran.Next(1, 3) == 2)
            {
                lista.Add("T");
            }
            else
            {
                lista.Add("P");
            }
            ////R, S e Z [8] label9
            if (ran.Next(1, 3) == 2)
            {
                lista.Add("R");
            }
            else if (ran.Next(1, 3) == 2)
            {
                lista.Add("S");
            }
            else
            {
                lista.Add("Z");
            }
            lista.Add("");
            lista.Add("");
            lista.Add("");
            lista.Add("");
            lista.Add("");
            lista.Add("");




            int listaIndex = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new string[5];

                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = lista[listaIndex];
                    listaIndex++;
                }
            }

            return matriz;

        }
        public static int Proximaletra(string letra)
        {
            int indice = 0;
            int pontos = 0;

            for (int i = 0; i < matriz.Length; i++)
            {

                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (Convert.ToString(letra[indice].ToString()) == matriz[i][j].ToString())
                    {
                        pontos++;
                        indice++;
                        break;
                    }

                    //if (Convert.ToString(letra[indice].ToString()) == matriz[i - 1][j].ToString())//Acima Norte
                    //{
                    //    pontos++;
                    //    indice++;
                    //}
                    //if (Convert.ToString(letra[indice].ToString()) == matriz[i + 1][j].ToString())//AbaixoSul
                    //{
                    //    pontos++;
                    //    indice++;
                    //}
                    //if (Convert.ToString(letra[indice].ToString()) == matriz[i][j + 1].ToString())// Direita Leste
                    //{
                    //    pontos++;
                    //    indice++;
                    //}
                    //if (Convert.ToString(letra[indice].ToString()) == matriz[i][j - 1].ToString())// Esquerda Oeste
                    //{
                    //    pontos++;
                    //    indice++;
                    //}
                    //if (Convert.ToString(letra[indice].ToString()) == matriz[i - 1][j + 1].ToString())//Acima Direita Nordeste
                    //{
                    //    pontos++;
                    //    indice++;
                    //}
                    //if (Convert.ToString(letra[indice].ToString()) == matriz[i - 1][j - 1].ToString())//Acima Esquerda Noroeste
                    //{
                    //    pontos++;
                    //    indice++;
                    //}
                    //if (Convert.ToString(letra[indice].ToString()) == matriz[i + 1][j + 1].ToString())//Abaixo Direita Sudeste
                    //{
                    //    pontos++;
                    //    indice++;
                    //}
                    //if (Convert.ToString(letra[indice].ToString()) == matriz[i + 1][j - 1].ToString())//Abaixo Esquerda Sudoeste
                    //{
                    //    pontos++;
                    //    indice++;
                    //}

                }


            }
            return pontos;
        }






















    }
}
