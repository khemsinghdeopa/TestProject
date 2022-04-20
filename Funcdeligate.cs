using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrectish
{
    internal class Funcdeligate
    {
        public delegate void GetPersion(PersionTech tech);
        public event EventHandler<PersionTech> persiondelevet;
        IEnumerable<int> intdata = null;
        public Funcdeligate()
        {
            intdata = new List<int>();
            persiondelevet += delegate
            {
                var fat = false;
            };
            persiondelevet += (sender, e) =>
            {
                var fat = false;
            };
        }
        public void functions()
        {
            Func<string, Task> funcdeligate = async (num) =>
             {
                 Task.Delay(1000).Wait();

             };

            Func<int, int, Task<int>> sumDel = async (num, num1) =>
               {
                   Task.Delay(1000).Wait();
                   int a = num + num1;
                   return a;
               };

            //var text = string? () => null;              
                    
                
        }
        public void HandleEvents()
        {
            persiondelevet?.Invoke(this, new PersionTech());
        }
    }

    internal class PersionTech
    {

    }
}
