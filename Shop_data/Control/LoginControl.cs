using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_data.Control
{
    public class LoginControl
    {
        DataDataContext data = null;
        public LoginControl()
        {
            data = new DataDataContext();
        }
        public int login(string user,string pass)
        {
            var res = data.check_login(user, pass).SingleOrDefault();
            if (res == null)
                return 0;
            else
            {
                return Convert.ToInt32(data.isRule(user, pass).ToString());
            }                
        }
        public LoginSystem GetByID(string userName)
        {
            return data.LoginSystems.SingleOrDefault(x => x.ID == userName);
        }
    }
}
