using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_System.sd_layer
{
    class USersIN
    {
        private String username;
        private String password;

        public USersIN(String username, String password) {
            UserName = username;
            Password = password;
        }


        public String UserName {
            get { return username; }
            set { username = value; }
        }
public String Password {
            get { return password; }
            set { password = value; }
        }

    }
}
