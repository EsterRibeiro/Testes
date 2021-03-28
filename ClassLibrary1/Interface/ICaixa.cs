using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Interface
{
    public interface ICaixa
    {
        ICollection<int> Saque(int valor);
        bool ValidaCedulasDisponiveis(int valor);
    }
}
