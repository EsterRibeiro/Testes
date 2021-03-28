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
        public ICollection<int> Saque(int valor)
        {
            var cedulasDacadas = new List<int>();
            int valorRestanteASerSacado = valor;
        }

        public bool ValidaCedulasDisponiveis(int valor)
        {
            throw new NotImplementedException();
        }
    }
}
