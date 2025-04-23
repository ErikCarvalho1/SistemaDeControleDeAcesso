using MySql.Data.MySqlClient;

namespace ControleDeAcessoClass
{
    public class Banco
    {
        public static MySqlCommand Abrir()
        {

            MySqlCommand cmd = new();
            string strConn = @"server=Localhost;database=controledeacesso;user=root;password=";
            MySqlConnection cn = new(strConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }

    }
}
