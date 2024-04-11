using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace SingletonExample
{
    public sealed class Singleton
    {     
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static Singleton GetObject 
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }          
        }
    }

    public static class Test //: Singleton
    {
        public static int MyProperty { get; set; }

        // this.Property

        // ctor (a,b) : this ()

        // void Alaki( this IEnumerable list )

        public static void DoAlaki(this string str)
        {

        }

        //public Test(){} // cant instance ctor

       // static Test(int a) // static ctor must be parameterless
        
        static Test()
        {
            // Singleton s1 = new Singleton();

           var s1 = Singleton.GetInstance();
           var s2 = Singleton.GetObject; 
        }

       
    }



    public class ParentClass
    {
        public virtual void Print ()
        {
            Console.WriteLine("Parent Print");
        }
    }

    public class ChildClass : ParentClass
    {
        public override void Print()
        {
            Console.WriteLine("Child Print");

            //this.Print();

            // 5*4
            // a * b ==> a = 1 result is b

            // a + b ==> a = 0 result is b


            base.Print();
        }
    }






    #region MyRegion
    public sealed class SingletonGuid
    {
        private SingletonGuid() { }

        private static Guid _instance;

        public static Guid GetInstance()
        {
            if (_instance == Guid.Empty)
            {
                _instance = Guid.NewGuid();
            }
            return _instance;
        }
    }
    #endregion


    #region MyRegion
    public sealed class SingletonGuidSafeThread
    {
        private SingletonGuidSafeThread() { }

        private static Guid _instance;

        private static readonly object _lock = new object();

        public static Guid GetInstance()
        {
            if (_instance == Guid.Empty)
            {
                lock (_lock)
                {
                    if (_instance == Guid.Empty)
                    {
                        _instance = Guid.NewGuid();
                    }
                }
            }
            return _instance;
        }
    }

    #endregion


}
