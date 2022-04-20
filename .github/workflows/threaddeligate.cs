using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testPrectish
{
    internal class threaddeligate:IDisposable
    {
        public AutoResetEvent autoResetEvent = null;
        private object _lock = new object();
        private bool _disposed = false;
        Queue<Template> _tempQueue = null;

        public threaddeligate()
        {
            autoResetEvent = new AutoResetEvent(false);
            _tempQueue = new Queue<Template>();
            ThreadPool.QueueUserWorkItem(CalculateTemplate);
        }

        public async void IncommingRequest(Template template)
        {
            
            _tempQueue.Enqueue(template);
            autoResetEvent.Set();
            await Task.Delay(100);
        }

        public void CalculateTemplate(object o)
        {
            while(!_disposed)
            {
                Template template = null;
                if (_tempQueue.Count > 0)
                {
                    lock (_lock)
                        template = _tempQueue.Dequeue();
                    if (template != null)
                        ParseResult(template);


                }
                else
                    autoResetEvent.WaitOne(1000);
            }
        }

        public void ParseResult(Template template)
        {

        }

        public void Dispose()
        {
            autoResetEvent = null;            
            _tempQueue.Clear();
            _tempQueue = null;
        }
    }

    public class Template
    {
        public string TempID { get; set; }

        public string TemplateName { get; set; }

        public void ParseString()
        {

        }
    }
}
