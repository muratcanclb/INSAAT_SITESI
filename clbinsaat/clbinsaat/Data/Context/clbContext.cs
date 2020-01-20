using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;

namespace clbinsaat.Data.Context
{
    public class clbContext : DbContext
    {
        public clbContext()
        {
          Database.Connection.ConnectionString = "server=clbinsaat.mssql.somee.com;database=clbinsaat;User Id=Xinner_SQLLogin_1;Password=Xinner55;persist security info=False";


          
        }
        public DbSet<user> users { get; set; }
        
    }

}
