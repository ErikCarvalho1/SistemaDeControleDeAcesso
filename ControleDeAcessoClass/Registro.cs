using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcessoClass
{
    class Registro
    {


        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public string TipoOperacao { get; set; } // Entrada ou Saída 

        public Registro(int id, int usuarioId, DateTime dataHora, string tipoOperacao)
        {
            Id = id;
            UsuarioId = usuarioId;
            Entrada = dataHora;
            Saida = dataHora;
            TipoOperacao = tipoOperacao;
        }
        public Registro( string nome, DateTime entrada, DateTime saida)
        {
           
            
            Entrada = entrada;
            Saida = saida;
           
        }
       
    }
}