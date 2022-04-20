using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrectish
{
    internal class Plinkfortask
    {
        public int PID { get; set; }
        public string Name { get; set; }

        public string Template { get; set; }
        public Plinkfortask()
        {

        }
        public void SetID(int id)
        {
            PID = id;
        }

        public string  GetData(int id)
        {
            return "khem";
        }

        public void ProcessData()
        {

        }
    }

    public class MappingData
    {
        int[] numbers = new int[100];
        public void FindData()
        {
            var data= ParallelEnumerable.Range(1,4).Select(i=>new Plinkfortask()).WithDegreeOfParallelism(2);
            data.ForAll(x => x.ProcessData());
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i]++;
            }
            var data1 = (numbers.Aggregate((n,m) => 
            {
                var multiply = (n * m);
                return multiply;
            
            }));
            
        }
    }
}
