using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Ex
{
    public class User
    {
        public event DisplayMsg AgeEvent;

        public int AcceptAge(int age)
        {
            if (age < 18)
            {
                AgeEvent();
            }
            return age;
        }
    }
}
