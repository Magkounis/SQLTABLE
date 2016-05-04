using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SQLTABLE
{
   public class RUN_QUERRY
    {
       public RUN_QUERRY()
       {
           querry = "SELECT STATE FROM WHMUSERS";
            connectionstring = "Server=MGK_LAPTOP;Database=ACTDB;User Id=sa;Password=actae1234!@#$;";
           SqlConnection sqlcon = new SqlConnection();
           sqlcon.ConnectionString = connectionstring;
           SqlCommand sqlcmd = new SqlCommand(querry,sqlcon);
           try
           {
               sqlcon.Open();
               SqlDataReader sqldtrd = sqlcmd.ExecuteReader();
             //  sqldtrd = 
               if (sqldtrd.HasRows)
               {
                   sqldtrd.Read();
                  state = sqldtrd.GetBoolean(0);
                  
                   sqlcmd.ExecuteNonQuery();
                   
               }

           }

           catch (Exception e)
           {


           }
           

       }

       public string connectionstring { get; set; }
       public string querry { get; set; }
       public bool state { get; set; }



    }
}
