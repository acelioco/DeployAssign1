using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace APMS
{
    public class DAL    {
        //Insert User details from Contact.aspx
        public void registerUser(string fname, string lname, string uname, string pwd, string mob, string hm, string email)
        {   
           // string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into Register values('"+ fname + "', '"+ lname + "', '"+ uname + "', '"+ pwd + "', '"+ mob + "', '"+ hm + "', '"+ email +"')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        //Select Login & Password for Admin Panel
        public int loginVerify (string userName, string password)
        {            
           // string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Select count(*) from Register where userName='" + userName + "' and Password='" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int counter = int.Parse(command.ExecuteScalar().ToString());
            connection.Close();
            return counter;
        }
    }
} 