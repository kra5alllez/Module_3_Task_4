using System;

namespace Module_3_Task_4_Vasylchnko
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClassDelegat classDelegat = new ClassDelegat();
            classDelegat.Starter();
            ClassLINQ c = new ClassLINQ();
            c.TestLINQ();
        }
    }
}
