using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
            cc.Print(); 

            Console.ReadKey();  


            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetObject;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }


            #region MyRegion
        
            Guid g1 = SingletonGuid.GetInstance();
            Guid g2 = SingletonGuid.GetInstance();
            Guid g3 = SingletonGuid.GetInstance();
            Guid g4 = SingletonGuid.GetInstance();

            Console.WriteLine($"G1 = {g1}");
            Console.WriteLine($"G2 = {g2}");
            Console.WriteLine($"G3 = {g3}");
            Console.WriteLine($"G4 = {g4}");

            Console.ReadKey();


            if (g1 == g2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
            #endregion


            Console.ReadKey();

            Console.Clear();


            #region MyRegion
            Thread t1 = new Thread(TestSingleton);
            Thread t2 = new Thread(TestSingleton);
            Thread t3 = new Thread(TestSingleton);
            Thread t4 = new Thread(TestSingleton);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();


            Console.ReadKey(); 
            #endregion

        }
        #region MyRegion
        public static void TestSingleton()
        {
            //Guid guid = SingletonGuid.GetInstance();
            Guid guid = SingletonGuidSafeThread.GetInstance();
            Console.WriteLine(guid);
        }
        #endregion


        //CURL WTTR.IN/TEHRAN
    }

}
