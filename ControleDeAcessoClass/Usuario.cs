using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcessoClass
{
    class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario() { }
        public Usuario(int id, string nome, string cpf, string email, string senha)
        {
            Id = id;
            Nome = nome;
            CPf = cpf;
            Email = email;
            Senha = senha;

        }
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new Usuario();
            string sql = "SELECT * FROM usuario WHERE id = @id";
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4)
                );

            }
            return usuario;
        }

        public static List<Usuario> ObterLista()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4)
                );

            }
            return usuarios;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into usuario (nome, cpf, email, senha) " +
                $"values ('{Nome}','{Email}',md5('{Senha}')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT LAST_INSERT_ID()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

    }
}
