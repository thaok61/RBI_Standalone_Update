﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBI.DAL.MSSQL
{
    class MSSQLDBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            
            /*Hoang:*/
            String serverName = @".\SQLEXPRESS";
            //String serverName = @"DESKTOP-L1AFIQR";
            //string serverName = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|RiskWISE5ProcessData.mdf;Integrated Security=True;";
            String DbName = "riskwise6";
            return SQL_DBConnectUtils.GetDBConnect(serverName, DbName);
        }       
    }
}
