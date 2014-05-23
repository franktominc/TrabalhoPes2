using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade {
    public class BDFacade {
        private DatabaseConnection oracleCon;
        private DatabaseConnection mySqlCon;
        private DatabaseConnection postGreCon;
        private static BDFacade instance;
        public static BDFacade getInstance() {
            if ( instance == null ) {
                instance = new BDFacade();
                return instance;
            }
            return instance;
        }
        private BDFacade() {

        }
        public void ConectaOracle() {
            oracleCon = new OracleConnection();
            oracleCon.Conect();
        }
        public void ConectaMySQL() {
            mySqlCon = new MySqlConnection();
            mySqlCon.Conect();
        }
        public void ConectaPostGre() {
            postGreCon = new PostgreConnection();
            postGreCon.Conect();
        }
    }
}
