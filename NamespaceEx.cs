using System;
using dd = Ns2.derived;
using Ns2derived = Ns2.inNs3.derived;
using Ns3inNsbase = Ns2.inNs3.inNsbase;

namespace NamespaceEx
{
    public class derived
    {
        public static void Piii()
        {
            Console.WriteLine("main method derived class");
           derived00.derived001();
        }
    }
    class NamespaceEx01:derived
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("main method");
            Piii();
            Ns2.Ns2Base.Ns02bases();
            dd derived2 = new dd();
            derived2.Ns2derived();
            Ns2derived.innerserived();
            Ns3inNsbase Nss2derived = new Ns3inNsbase();
            Nss2derived.inmethod();

        }
    }
    public class derived00
    {
        public static void derived001()
        {
            Console.WriteLine("main method base00");
        }
  }


}

namespace Ns2
{
    public class Ns2Base
    {
        public static void Ns02bases()
        {
            Console.WriteLine("Ns2 Namespace Ns2base class Ns02bases method calleed");
        }
    }
  
    class  derived:Ns2Base
    {
            public void Ns2derived()
            {
                Console.WriteLine(" Ns2 namespace   derivied ");
            Ns02bases();
               
            }
    }
    namespace inNs3
    {
        class inNsbase
        {
            public void inmethod()
            {
                Console.WriteLine("inNs3 base class method");
            }
        }
        class derived:inNsbase
        {
            public static void innerserived()
            {
                Console.WriteLine("inNs3 derived class method");               
                
            }
        }
    }
}
