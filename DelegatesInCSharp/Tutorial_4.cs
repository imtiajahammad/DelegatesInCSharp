using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{
    public delegate void SampleDelegate();
    public delegate int SampleDelegate_withReturn();
    public delegate void SampleDelegate_OutParameter(out int Integer);
    class Tutorial_4
    {
        public Tutorial_4()
        {
            ///you can also send lambda expression for the functin pointer
            Console.WriteLine("\r\nTutorial_4-implementation-simple single cast delegate-start");
            Console.WriteLine("----------------------------------------Multicast delegate way-0");
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del();
            Console.WriteLine("\r\nTutorial_4-implementation-simple single cast delegate-end");


            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate by assigning into one delegate-start");
            Console.WriteLine("----------------------------------------Multicast delegate way-1");
            SampleDelegate sdel1, sdel2, sdel3, sdel4;
            sdel1 = new SampleDelegate(SampleMethodOne);
            sdel2 = new SampleDelegate(SampleMethodTwo);
            sdel3 = new SampleDelegate(SampleMethodThree);
            sdel4 = sdel1 + sdel2 + sdel3;
            sdel4();
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate by assigning into one delegate-end");

            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate by assigning into one delegate and remove one delegate-start");
            Console.WriteLine("----------------------------------------Multicast delegate way-2");
            sdel4 -=sdel2;
            sdel4();
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate by assigning into one delegate and remove one delegate-end");

            Console.WriteLine("----------------------------------------Multicast delegate way-3");
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate by assigning into one of them-start");
            SampleDelegate sampleDelegate = new SampleDelegate(SampleMethodTwo);
            sampleDelegate += SampleMethodThree;
            sampleDelegate += SampleMethodTwo;
            sampleDelegate += SampleMethodThree;
            sampleDelegate += SampleMethodTwo;
            sampleDelegate();
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate by assigning into one of them-end");
            Console.WriteLine("----------------------------------------Multicast delegate way-4");
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate with return type but no assign to variable-start");
            SampleDelegate_withReturn sampleDelegate_WithReturn = new SampleDelegate_withReturn(SampleMethodOne_withReturn);
            sampleDelegate_WithReturn += SampleMethodTwo_withReturn;
            sampleDelegate_WithReturn();
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate with return type but no assign to variable-end");
            Console.WriteLine("----------------------------------------Multicast delegate way-5");
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate with return type-start");
            int returnInteger = sampleDelegate_WithReturn();//It will always return you the return value from the last delecate you added in
            Console.WriteLine("Delegate return value -> {0}", returnInteger);
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate with return type-end");
            Console.WriteLine("----------------------------------------Multicast delegate way-6");
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate with OUT_PARAMETER-start");
            SampleDelegate_OutParameter sampleDelegate_OutParameter = new SampleDelegate_OutParameter(SampleMethodOne_OutParameter);
            sampleDelegate_OutParameter += SampleMethodTwo_OutParameter;
            int delegateOutputParameterValue = -1;
            sampleDelegate_OutParameter(out delegateOutputParameterValue);
            Console.WriteLine("DelegateReturnedValue = {0}" , delegateOutputParameterValue);
            Console.WriteLine("\r\nTutorial_4-implementation-multicast delegate with OUT_PARAMETER-end");

        }
        public void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
        public int SampleMethodOne_withReturn()
        {
            return 1;
        }
        public int SampleMethodTwo_withReturn()
        {
            return 2;
        }
        public void SampleMethodOne_OutParameter(out int number)
        {
            number =1;
        }
        public void SampleMethodTwo_OutParameter(out int number)
        {
            number=2;
        }
    }

}
