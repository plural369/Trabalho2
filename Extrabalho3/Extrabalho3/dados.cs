using System;
using System.Collections.Generic;
using System.Text;

namespace Extrabalho3
{
    public class dados : IComparable<dados>

    {
        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public int Telefone { get; set; }

        public int CNPJ { get; set; }

        public int CEP { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int Celular { get; set; }

        public int CompareTo(dados dado)
        {
            return this.Nome.CompareTo(dado.Nome);
        }

    }

    
}
