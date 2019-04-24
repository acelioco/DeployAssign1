using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Text;
using System.Security.Cryptography;

namespace APMS
{
    public class Security
    {
        public static string GetHash(string password)
        {
            byte[] passwordByte = ASCIIEncoding.ASCII.GetBytes(password);

            HashAlgorithm algorithm = new HMACSHA512();
            byte[] hashPassword = algorithm.ComputeHash(passwordByte);
            return Convert.ToBase64String(hashPassword);
        }
      
    }   
}