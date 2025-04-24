using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcessoClass
{
   public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public int Tipo_Usuario { get; set; }
        public string Senha { get; set; }
       public bool Ativo { get; set; }

        public Usuario() { }
        public Usuario(int id, string nome, string cpf, string email, int tipo_usuario, string senha,bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Tipo_Usuario = tipo_usuario;
            Senha = senha;
           


        }
        public Usuario( int id,string nome ,string cpf ,string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
          Email = email;
            //txtNome.Text, txtEmail.Text, txtCpf.Text, txtSenha.Text
        }
        public Usuario( string nome, string email, string cpf, int tipo_usuario, string senha)
        {
            
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Tipo_Usuario = tipo_usuario;
            Senha = senha;
        }
      
        public Usuario(string email,  string senha, bool ativo)
        {
            Email = email;
            Senha = senha;
            Ativo = ativo;

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
                dr.GetInt32(4),
                dr.GetString(5),
                dr.GetBoolean(6)

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
                dr.GetString(3)
          
                );

            }
            return usuarios;
        }

        public void Inserir()
        {
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = $"INSERT INTO usuarios (nome, cpf, email, tipo_usuario, senha, ativo) " +
                   $"VALUES ('{Nome}', '{Cpf}', '{Email}', {Tipo_Usuario}, MD5('{Senha}'), 1)";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT LAST_INSERT_ID()";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }



        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new Usuario();
            string sql = "SELECT * FROM usuarios WHERE email = @Email AND senha = MD5(@Senha)";

            var cmd = Banco.Abrir();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Senha", senha);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.Id = dr.GetInt32("id");
                usuario.Nome = dr.GetString("nome");
                usuario.Email = dr.GetString("email");
                usuario.Ativo = dr.GetBoolean("ativo");
                
            }

            return usuario;
        }

    }
}
