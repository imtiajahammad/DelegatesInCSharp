using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ///concept-start
            string delegates = "DELEGATES: A delegate is a type safe function pointer." +
                "\r\n[A delegate points to a function and when you invoke this delegate, the function invokes." +
                "\r\nWhy do you have to create a delegate make it point to a function and then invoke the delegate? " +
                "\r\nWhy do not we call the function directly?\r\nThe reason is flexibility.";

            string multicast_delegates = "\r\nMULTICAST DELEGATES: A multicast delegate is a delegate that has references to more than on function. " +
                "\r\nWhen you invoke a multicast delegate, all the function''s the delegate is pointing to, are invoked. " +
                "\r\nThere are 2 approaches to create a multicast delegate.Depending on the approach you use-" +
                "\r\n+ or += to register a mehtod with the delegate " +
                "\r\n- or -= to un - register a method with the delegate." +
                "\r\n\r\nA multicast delegate, invokes the methods in the invocation list, in the same order in which they are added. " +
                "\r\nIf the delegate has a return type other than void and if the delegate is a multicast delegate, only the value of the last invoked method will be returned.Along the same lines," +
                " if the delegate has an out parameter, the value of the output parameter, will be the values assigned by the last method.";
            string extra_info = "\r\nOne common interview question is that- Where do you use multicast delegates?Multicast delegate makes implementation of observer design pattern very simple. " +
                "Observer pattern is also called as publish / subscribe pattern";
            Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n\r\n", delegates, multicast_delegates, extra_info);
            ///concept-end
            Console.WriteLine("-------------------------START OF Tutorial_1--------------------------\r\n");
            Tutorial_1 tutorial_1 = new Tutorial_1();
            Console.WriteLine("\r\n-------------------------END OF Tutorial_1----------------------------\r\n");
            Console.WriteLine("-------------------------START OF Tutorial_2--------------------------\r\n");
            Tutorial_2 tutorial_2 = new Tutorial_2();
            Console.WriteLine("\r\n-------------------------END OF Tutorial_2----------------------------\r\n");
            Console.WriteLine("-------------------------START OF Tutorial_3--------------------------\r\n");
            Tutorial_3 tutorial_3= new Tutorial_3();
            Console.WriteLine("\r\n-------------------------END OF Tutorial_3----------------------------\r\n");
            Console.WriteLine("-------------------------START OF Tutorial_4--------------------------\r\n");
            Tutorial_4 tutorial_4 = new Tutorial_4();
            Console.WriteLine("\r\n-------------------------END OF Tutorial_4----------------------------\r\n");



            Console.WriteLine("\r\n\r\nReference:: {0}", "https://www.youtube.com/watch?v=D2h46fvQX04&list=PLAC325451207E3105&index=36&ab_channel=kudvenkatkudvenkat");
            Console.ReadKey();
        }
    }

}
