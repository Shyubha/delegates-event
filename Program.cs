using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
              //public delegate void ErrorDelegate();
              //hold method ref >> failMsg, PassMsg,Age >18
        public delegate void DisplayMsg();//Delegate is type so we can write in namespace..
        class Program
        {
            static void min3ths()
            {
                Console.WriteLine("Your Balance is belo 3000rs.");
            }
            static void zerobal()
            {
                Console.WriteLine("Your Balance is zero.");
            }
            static void cntwithdr()
            {
                Console.WriteLine("Insufficient Balance.");
            }

            static void FailMsg()
            {
                Console.WriteLine("Oops... You are Fail.");
            }
            static void PassMsg()
            {
                Console.WriteLine("Congratulation...! You are pass.");
            }
            static void ErrorMsg()
            {
                Console.WriteLine("This user is not valid for vote.");
            }
            static void Main(string[] args)
            {
                User user = new User();
                user.AgeEvent += new DisplayMsg(ErrorMsg);
                int age = user.AcceptAge(12);
                Console.WriteLine("Your age is :" + age);

                Console.WriteLine("\n========Student_Delegate Class delegate Object =========\n");
                Student_Delegate student = new Student_Delegate();
                student.FailEvent += new DisplayMsg(FailMsg);
                student.PassEvent += new DisplayMsg(PassMsg);
                student.AcceptMarks(34);
                Console.WriteLine("Your marks is less then 40 .");

                Console.WriteLine("\n========Bank Class  =========");
                Bank amount = new Bank();
                amount.min3ths += new DisplayMsg(min3ths);
                amount.zerobal += new DisplayMsg(zerobal);
                amount.cntwithdr += new DisplayMsg(cntwithdr);
                // Console.WriteLine("Enter the amount Deposit ::");
                // double dep = double.Parse(Console.ReadLine());
                // amount.Deposit(3000);
                // Console.WriteLine("Enter the amount Deposit ::");
                // double wbal = double.Parse(Console.ReadLine());
                Console.WriteLine("Wlcome to :" + amount.b_name + "\nIFSC: " + amount.ifsc);
            start:
                Console.WriteLine("a.Deposite  b.Withdrawal c.CheckBalance");
                Console.WriteLine("Enter the operation");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("Enter the amount to Deposite");
                        double amt1 = Convert.ToInt32(Console.ReadLine());
                        amount.Dpose(amt1); break;

                    case 'b':
                        Console.WriteLine("Enter the amount to withdreaw");
                        double wamt = Convert.ToInt32(Console.ReadLine());
                        amount.withdrow(wamt); break;
                    case 'c':
                        Console.WriteLine(" Your Account Balance is");

                        amount.show(); break;
                    default: Console.WriteLine("Thank you Viist Again:"); break;
                }

                goto start;
            }
        }
    }
}
