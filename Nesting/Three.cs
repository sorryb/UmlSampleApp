using System;

namespace Nesting
{
    public class Three
    {
        public Nest _nesting;
        public Three()
        {
            Nest nest = new Nest();
            _nesting = nest;
        }

        public class Nest
        {
            public Nest()
            {
                    Console.WriteLine("I am nested.");
            }

        }

    }


}