using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuongTacCheo
{
    class Info
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String Cookie { get; set; }

        public Info(string username, string password, string cookie)
        {
            Username = username;
            Password = password;
            Cookie = cookie;
        }

        public Info()
        {
        }
    }
}
