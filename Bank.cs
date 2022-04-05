using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Ex
{
    public class Bank
    {
        public string b_name;
        public string ifsc;
        public static double amount;

        public event DisplayMsg min3ths;
        public event DisplayMsg zerobal;
        public event DisplayMsg cntwithdr;

        public Bank()
        {
            b_name = "BOI";
            ifsc = "000MPBOI";
            amount = 0;
        }



        public void Dpose(double amt)
        {

            amount = amount + amt;
            Console.WriteLine("Avail Balance:" + amount);
            // return  amount;

        }
        public void show()
        {
            Console.WriteLine("Balance " + amount);
        }
        public void withdrow(double amt)
        {
            //double namt = amt;
            double bal1 = amount - amt;
            if (amount <= 0)
            {

                zerobal();

            }
            else if (amt < amount)
            {
                amount = amount - amt;

            }
            else if (amt > amount)
            {
                cntwithdr(); //break;
                //Console.WriteLine("cant withdraw");
            }

            else if (bal1 < 3000)
            {
                amount = amount - amt;
                min3ths();

                //Console.WriteLine("cant withdraw");
            }
        }


    }
}
