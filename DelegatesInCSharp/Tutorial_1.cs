using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{
    /// <summary>
    /// having the delegate term to make delegates
    /// having the similar return type as pointer function
    /// </summary>
    /// <param name="Message"> having the similar parameter as pointer funciton</param>
    public delegate void DelegateToCallHelloFunction(string Message);


    class Tutorial_1
    {
        public Tutorial_1()
        {
            /// <summary>
            /// make an instance of the delegate to call;
            /// to call it, you have to add the value type as parameter [ as delegate is type safe, compiler will get error if type of parameter is not similar with delegate parameter];
            /// </summary>
            /// <param name="Hello"> having the pointer function name as instance parameter</param>
            DelegateToCallHelloFunction delegateToCallHello = new DelegateToCallHelloFunction(Hello);
            delegateToCallHello("hello from DelegateToCallHello Function");
        }





        /// <summary>
        /// this function is the function which our delegate is going to point;
        /// any normal function with a string data type parameter.
        /// </summary>
        /// <param name="strMessage"></param>
        public void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

}
