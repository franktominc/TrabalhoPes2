using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_FacadeSemPadrao {
    class Program {
        static void Main(string[] args) {
            DatabaseConnection mysql = new MySqlConnection();
            DatabaseConnection oracle = new OracleConnection();
            DatabaseConnection postgre = new PostgreConnection();
            mysql.Connect();
            oracle.Connect();
            postgre.Connect();
            Console.ReadKey();
        }
    }
}
