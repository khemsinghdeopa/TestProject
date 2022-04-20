using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrectish
{
    internal class testGenric<T> where T: class
    {
        int index = 0;
        private T[] obj = new T[int.MaxValue];
        public void Add(T input)
        {
            obj[index++] = input;
        }
        public T this[int index]
        {
            get
            {
                return obj[index];
            }
            set
            {
                obj[index] = value;
            }
        }
    }
    public abstract class People
    {
        public abstract T GetPeople<T>();
        public abstract void  AddPeople<T>(T people);
    }

    //public class TypeOfPeople : People
    //{
        //public override void AddPeople<T>(T people) where T:default
        //{
            //throw new NotImplementedException();
        //}

        //public override T GetPeople<T>() where T : default
        //{
            //throw new NotImplementedException();
        //}
    //}
    internal class testStruct<T> where T : ICollection<T>
    {

    }

    public static class TExtentiom
    {
        public static T GetMaxObject<T>(this T Typeofc) where T : struct
        {
            T obj= Typeofc;
            return obj;
        }
    }
}
