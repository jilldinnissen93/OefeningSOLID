using System;

namespace ProgramMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Dag1Code.Code code = new Dag1Code.Code();
            Console.WriteLine(code.FollowPath());
        }
    }
}
