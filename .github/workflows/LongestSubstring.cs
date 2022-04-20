using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrectish
{
    internal class LongestSubstring
    {
        public int Longestsubstring(string stringarray)
        {
            char[] singleData = stringarray.ToCharArray();
            int j = 0;
            int maxlength = 0;
            List<char> subSet= new List<char>();
            for(int i = 0; i < singleData.Length; i++)
            {
                while(subSet.Contains(singleData[i]))
                {
                    subSet.RemoveAt(j);
                    j++;
                }                
                subSet.Add(singleData[i]);                
                maxlength =Math.Max (maxlength,(i - j) + 1);
            }
            return maxlength;
        }        
    }
}
