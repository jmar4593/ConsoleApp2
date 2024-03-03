using System;
using Console2;

namespace Console3
{
    interface IFromProgram
    {
        public void InheritThingFromSameFile()
        {

        }
    }


    public class GoodStuff : IFromProgram2, IFromProgram
    {
        //Interfaces should be yelling at me for not
        //enforcing their contracts, but they aren't
        //doing anything. Why aren't they doing
        //anything.

    }
}


