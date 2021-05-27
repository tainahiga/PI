using MySql.Data.MySqlClient; //deve ser instalado
using System;
using System.Collections.Generic;
using System.Data;              //existe no sistema só precisa ser importado
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    public class Database
    {
        private MySqlConnection conn;       //connection - gerencia as conexões com o banco
        private DataTable data;             //gerencia tabelas de dados
        private MySqlDataAdapter da;        //converter do banco de dados para um objeto
        private MySqlDataReader dr;         //leitura de dados
        private MySqlCommandBuilder cb;     //construtor de comando

        public static String server = "localhost";
        public static String user = "root";
        public static String password = "Salabim24";
        public static String database = "pi_uscs_3an";

        public void Conectar()
        {
            if (conn != null)
                conn.Close();

            string connStr = String.Format("Server={0};user id={1};password={2}; database={3};pooling=false", server, user, password, database);

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // USADO PARA = INSERT - UPDATE - DELETE
        public long ExecutarComandoSQL(string comandoSql, bool ReturnLastInsertedId = false)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery();
            long id = comando.LastInsertedId;
            conn.Close();
            if (ReturnLastInsertedId == true)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }

        //SELECTS
        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }
        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            return dr;
        }
    }
}