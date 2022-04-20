using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrectish
{
    internal class Instances
    {
        public int InstanceId { get; set; }

        public string Slug { get; set; }

        public delegate void OnLoad();

        public event OnLoad LoadInstances;

    }
}
