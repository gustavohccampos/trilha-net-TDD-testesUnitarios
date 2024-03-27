using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraOperacoes
    {
        private List<string> listaHistorico;

        public CalculadoraOperacoes() {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int resp =  num1 + num2;
            listaHistorico.Insert(0, "Resp: " + resp);
            return resp;
    
        }

        public int Subtrair(int num1, int num2)
        {

            int resp = num1 - num2;
            listaHistorico.Insert(0, "Resp: " + resp);
            return resp;
        }

        public int Multiplicar(int num1, int num2)
        {

            int resp = num1 * num2;
            listaHistorico.Insert(0, "Resp: " + resp);
            return resp;
        }

        public int Dividir(int num1, int num2)
        {

            int resp = num1 / num2;
            listaHistorico.Insert(0, "Resp: " + resp);
            return resp;
        }

         public List<string> Historico()
          {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
                  return listaHistorico ;
          }

    }
}