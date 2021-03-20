using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_AEVO.Classes
{
    public class CConexao
    {
        public static string GET_StringConexao()
        {
            string Host = "localhost";
            string Banco = "dbapi_weather";
            string Usuario = "root";
            string Senha = "1234";
            return "Data Source=" + Host + ";Initial Catalog=" + Banco + ";User Id=" + Usuario + ";Password=" + Senha + ";";
        }
    }
}
