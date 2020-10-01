using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Project2
{
    class LoginHandler
    {
        string path = @"PlayerLogin.txt";

        public delegate void myDel(string un, string pw);
        public event myDel sendEvent;

        public void loginEvent(string user, string pass)
        {
            if (sendEvent!= null)
            {
                sendEvent(user, pass);
            }
        }

        public bool Search(string userName, string password)
        {
            string fullpath;

            fullpath = Path.GetFullPath(path);

            bool result = false;
            int index;
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            while (line!=null)
            {
                index = line.IndexOf(",");
                string[] player = line.Split(new char[] { ',' });
                if ((player[0]==userName)&&(player[1]==password))
                {
                    result = true;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return result;
        }

        //Check for empty field
        public bool checkNull(string user, string pass)
        {
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter username");
                return false;
            }
            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Enter password");
                return false;
            }
            {
                return true;
            }
        }

        public bool registervalidation(string user)
        {
            string fullPath;
            fullPath = Path.GetFullPath(path);

            bool result = false;
            int Index;
            StreamReader sr = new StreamReader(path);
            string Line = sr.ReadLine();
            while (Line!=null)
            {
                Index = Line.IndexOf(",");
                string[] player = Line.Split(new char[] { ',' });
                if (player[0]==user)
                {
                    result = true;
                }
                Line = sr.ReadLine();
            }
            sr.Close();
            return result;
        }

        public bool Validate(string a , string b)
        {
            if (checkNull(a,b)==false)
            {
                return false;
            }
            else if (Search(a,b)==false )
            {
                MessageBox.Show("Incorrect username or password");
                return false;
            }
            {
                return true;
            }
        }

    }
}
