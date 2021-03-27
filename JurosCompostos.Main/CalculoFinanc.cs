using System;
using System.Collections.Generic;
using System.Text;

namespace JurosCompostos.Main
{
    public static class CalculoFinanc
    {
        public static double CalcularValorComJurosCompostos(double valorEmprestimo, int numMeses, double taxa)
        {
            // return double.MinValue;

            return Math.Round(valorEmprestimo * Math.Pow((1 + taxa / 100), numMeses), 2);
        }
    }
}
