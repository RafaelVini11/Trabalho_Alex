using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Alex.infraestrutura
{
    public class DBconnection
    {
        public NpgsqlConnection Connection { get; set; }

        public DBconnection()
        {
            Connection = new NpgsqlConnection(
             "Host=localhost;Port=5432;Database=estoque;Username=postgres;Password=1234"
         );
            Connection.Open();
        }
    }
}
