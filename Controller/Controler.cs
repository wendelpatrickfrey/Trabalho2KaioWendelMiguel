using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Model;

namespace Teste.Controller
{
    public static class Controler
    {
        public static string[][] matriz;


        //Gerador automatico de letras em matriz c#
        public static string[][] Gerador()
        {
            matriz = Functions.Gerador();
            return matriz;
        }
             


        
        

    }

}
