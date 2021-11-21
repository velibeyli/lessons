using System;

namespace VirtualKeyword
{
    public class A
    {
        public string AName { get; set; }
        public string ASurname{ get; set; }
        public virtual string Common { get; set; } 
        public virtual void ShowMyClassName()
        {
            //Console.WriteLine("This method called from class A");
            //Console.WriteLine("Hello A");
        }

        public void NotVirtualMethod()
        {
            Console.WriteLine("This is not virtual method and  defined in  A class");
        }
       /* public virtual void Aa(); // wrong - virtual method can not defined as an abstract class */
       public virtual void ZMethod()
        {
            Console.WriteLine("ZMethod in A class");
        }
        public virtual void Hello()
        {
            Console.WriteLine(Common);
        }
        
        public virtual void Hello(string letter)
        {

        }
    }
}
