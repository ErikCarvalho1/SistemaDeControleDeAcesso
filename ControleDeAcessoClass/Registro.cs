using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcessoClass
{
    class Registro
    {


        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataHora { get; set; }

        public string TipoOperacao { get; set; } // Entrada ou Saída 

        public Registro(int id, int usuarioId, DateTime dataHora, string tipoOperacao)
        {
            Id = id;
            UsuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperacao = tipoOperacao;
        }
    }
}