using System;

namespace _49AccessModifiersProtectedInternal
{
    class Rahul
    {
        public  virtual void Printu()
        {
            Console.WriteLine("This is the rahul Printu");
        }
    }
     class Shubham:Rahul
    {
        private static void Prints()
        {
            Console.WriteLine("Print Method");
        }
    
        public  sealed override void Printu()
        {
            Console.WriteLine("Printu");
            //Shubham.Prints();
        }
       
    }
    class Vishal : Shubham
    {
        public override void Printu()
        {
            Console.WriteLine("vishal Printu");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Rahul s = new Shubham();
            s.Printu();
            Shubham r = new Vishal();
            r.Printu();
            
        }

    }
    
}
