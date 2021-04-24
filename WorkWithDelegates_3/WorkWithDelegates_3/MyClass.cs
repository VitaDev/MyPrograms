using System;

namespace WorkWithDelegates_3
{
    public class MyClass
    {
        public MyClass(int number)
        {
            this.Number = number;
        }

        public Func<int, int> alphaEvent;
        public int Number { get; set; }
    }
}
