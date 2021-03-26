using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_Task_4_Vasylchnko
{
    public class ClassDelegat
    {
        private event Func<int, int, int> DelegatFunk;

        public void Starter()
        {
            DelegatFunk += Sum;
            DelegatFunk += Sum;
            var sum = 0;
            TryCatch(() =>
            {
                foreach (var item in DelegatFunk.GetInvocationList())
                {
                    sum += (int)item.DynamicInvoke(2, 5);
                }
            });

            Console.WriteLine(sum);
        }

        public void TryCatch(Action dlelegat)
        {
            try
            {
                dlelegat.Invoke();
            }
            catch
            {
            }
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
