using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweepCake
{
    [Serializable]
    public class UserLogin
    {
        public string UserID { set; get; }
        public int IdRule { set; get; }
    }
}