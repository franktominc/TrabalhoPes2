﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade {
    public class MySqlConnection : DatabaseConnection{
        public void Conect() {
            Console.WriteLine("Conectando com Mysql");
        }
    }
}
