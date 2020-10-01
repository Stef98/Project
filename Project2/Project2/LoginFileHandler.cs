using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class LoginFileHandler
    {
        string path = @"PlayerLogin.txt";
        public void register(string username, string pass)
        {
            string fullpath = Path.GetFullPath(path);
            var line = username + "," + pass;

            File.AppendAllText(fullpath, line + Environment.NewLine);
        }

       
    }
}
