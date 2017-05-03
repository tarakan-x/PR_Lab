using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_PR_02
{
     class Program
     {
          static ManualResetEvent mRes = new ManualResetEvent(false);
          static AutoResetEvent t2Reset = new AutoResetEvent(false);
          static AutoResetEvent t3Reset = new AutoResetEvent(false);
          static AutoResetEvent t4Reset = new AutoResetEvent(false);
          static AutoResetEvent t5Reset = new AutoResetEvent(false);
          static AutoResetEvent t6Reset = new AutoResetEvent(false);



          static void Main(string[] args)
          {
               Thread th1 = new Thread(thWork1);
               Thread th2 = new Thread(thWork2);
               Thread th3 = new Thread(thWork3);
               Thread th4 = new Thread(thWork4);
               Thread th5 = new Thread(thWork5);
               Thread th6 = new Thread(thWork6);
               th1.Start();
               th2.Start();
               th3.Start();
               th4.Start();
               th5.Start();
               th6.Start();

               Console.ReadLine();
          }

         private static void thWork6()
         {
               t5Reset.WaitOne();
               mRes.WaitOne();
               Console.WriteLine("Thread 6");

         }

          private static void thWork5()
          {
               t4Reset.WaitOne();
               mRes.WaitOne();
               Console.WriteLine("Thread 5");
               t5Reset.Set();
          }

          private static void thWork4()
          {
               t3Reset.WaitOne();
               mRes.WaitOne();
               Console.WriteLine("Thread 4");
               t4Reset.Set();
          }

          private static void thWork3()
          {
               t2Reset.WaitOne();
               mRes.WaitOne();
               Console.WriteLine("Thread 3");
               t3Reset.Set();
          }

          private static void thWork2()
          {
               Console.WriteLine("Thread 2");
               mRes.Set();
          }

          private static void thWork1()
          {
               Console.WriteLine("Thread 1");
               t2Reset.Set();
          }
     }
}
