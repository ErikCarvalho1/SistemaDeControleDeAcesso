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
        public string? Cpf { get; set; }
        public string Email { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public string Tipo_Usuario { get; set; }
        public string Senha { get; set; }
       public bool Ativo { get; set; }

       

        public Usuario() { }
        public Usuario(int id, string nome, string cpf, string email, DateTime entrada, DateTime saida,string tipo_usuario, string senha,bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Tipo_Usuario = tipo_usuario;
            Senha = senha;
            Entrada = entrada;
            Saida = saida;

        }
        public Usuario( int id,string nome ,string cpf ,string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
           Email = email;
            //txtNome.Text, txtEmail.Text, txtCpf.Text, txtSenha.Text
        }
        public Usuario( string nome, string email, string cpf, string tipo_usuario, string senha)
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
        public Usuario(string nome, DateTime entrada, DateTime saida)
        {


            Entrada = entrada;
            Saida = saida;

        }


        public static Usuario ObterPorNome(string nome)
        {
            Usuario usuario = null;
            string sql = @"
        SELECT u.Id, u.Nome, u.Cpf, u.Email, ra.Entrada, ra.Saida, u.Tipo_usuario, u.Senha, u.Ativo
        FROM RegistroDeAcesso ra
        JOIN Usuarios u ON ra.Usuario_Id = u.Id
        WHERE u.Nome = @Nome";
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Nome", nome);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new Usuario();

                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Cpf = dr.GetString(2);
                usuario.Email = dr.GetString(3);
                usuario.Entrada = dr.IsDBNull(4) ? (DateTime?)null : dr.GetDateTime(4);
                usuario.Saida = dr.IsDBNull(5) ? (DateTime?)null : dr.GetDateTime(5);
                usuario.Tipo_Usuario = dr.GetString(6);
                usuario.Senha = dr.GetString(7);
                usuario.Ativo = dr.GetBoolean(8);

            }
            return usuario;
        }

        public static List<Usuario> ObterListaComRegistro()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string sql = @"
    SELECT u.Id, u.Nome, ra.Entrada, ra.Saida
    FROM RegistroDeAcesso ra
    JOIN Usuarios u ON ra.Usuario_Id = u.Id
    ORDER BY ra.Entrada DESC";

            var cmd = Banco.Abrir();
            cmd.CommandText = sql;
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();

                usuario.Id = dr.IsDBNull(0) ? 0 : dr.GetInt32(0);
                usuario.Nome = dr.IsDBNull(1) ? "" : dr.GetString(1);
                usuario.Entrada = dr.IsDBNull(2) ? (DateTime?)null : dr.GetDateTime(2);
                usuario.Saida = dr.IsDBNull(3) ? (DateTime?)null : dr.GetDateTime(3);

                usuarios.Add(usuario);
            }

            return usuarios;
        }
        public void Inserir()
        {
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = $"INSERT INTO usuarios (nome, cpf, email, tipo_usuario, senha, ativo) " +
                   $"VALUES ('{Nome}', '{Cpf}', '{Email}', '{Tipo_Usuario}', MD5('{Senha}'), 1)";

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
        public  void RegistrarEntrada()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = @"
        INSERT INTO RegistroDeAcesso (Usuario_Id, Entrada)
        VALUES (@UsuarioId, @Entrada)";

            cmd.Parameters.AddWithValue("@UsuarioId", Id);
            cmd.Parameters.AddWithValue("@Entrada", DateTime.Now);
            cmd.ExecuteNonQuery();
        }
        public void RegistrarSaida()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = @"
        UPDATE RegistroDeAcesso 
        SET Saida = @Saida 
        WHERE Usuario_Id = @UsuarioId AND Saida IS NULL
        ORDER BY Entrada DESC
        LIMIT 1";

            cmd.Parameters.AddWithValue("@UsuarioId", Id);
            cmd.Parameters.AddWithValue("@Saida", DateTime.Now);
            cmd.ExecuteNonQuery();  
        }

    }
}
