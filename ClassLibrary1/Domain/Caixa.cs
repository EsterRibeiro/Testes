using CaixaEletronico.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Domain
{
    /// <summary>
    /// Herda da interface ICaixa e implementa seus métodos
    /// </summary>
    public class Caixa : ICaixa
    {
        //verifica a quantidade de cédulas a serem sacadas
        public ICollection<int> Saque(int valor)
        {
            var cedulasSacadas = new List<int>();
            int valorRestanteASerSacado = valor;

            while(valorRestanteASerSacado >= Cedula.Cem)
            {
                cedulasSacadas.Add(Cedula.Cem); //adiciona a de 100
                valorRestanteASerSacado = valorRestanteASerSacado - Cedula.Cem;//adiciona restante

            }

            while (valorRestanteASerSacado >= Cedula.Cinquenta)
            {
                cedulasSacadas.Add(Cedula.Cinquenta); //adiciona a de 100
                valorRestanteASerSacado = valorRestanteASerSacado - Cedula.Cinquenta;//adiciona restante

            }

            while (valorRestanteASerSacado >= Cedula.Vinte)
            {
                cedulasSacadas.Add(Cedula.Vinte); //adiciona a de 100
                valorRestanteASerSacado = valorRestanteASerSacado - Cedula.Vinte;//adiciona restante

            }

            while (valorRestanteASerSacado >= Cedula.Dez)
            {
                cedulasSacadas.Add(Cedula.Dez); //adiciona a de 100
                valorRestanteASerSacado = valorRestanteASerSacado - Cedula.Dez;//adiciona restante

            }

            if (cedulasSacadas.Count == 0)
                throw new Exception("Não há cédulas disponíves");

            return cedulasSacadas;

        }

        public bool ValidaCedulasDisponiveis(int valor)
        {
            return valor % 10 == 0; //resto for igual a 0
        }
    }
}
