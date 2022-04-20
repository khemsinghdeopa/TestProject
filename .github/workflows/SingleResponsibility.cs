using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrectish
{
    public class Playlist : BaseAbstract,IDisposable
    {

        protected IPlaylistInstance _Instances = null;


        /// <summary>
        /// Load standered Playlist
        /// </summary>
        /// <param name="instance"></param>
        public Playlist(IPlaylistInstance instance)
        {
            _Instances=instance;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void LoadPlaylist()
        {
            _Instances.GetAllInstances();
        }


        /// <summary>
        /// 
        /// </summary>
        public override void UnloadPlaylist()
        {
            
        }


        public virtual void Dispose()
        {
            
        }
    }

    public class CommandPlaylist : Playlist, IValidity
    {
        public CommandPlaylist(IPlaylistInstance instance) : base(instance)
        {

        }     

        public void Visibiliy()
        {
            
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }

    public class Maindata
    {
        public void loadPlaylist()
        {
            BaseAbstract baseAbstract = new CommandPlaylist(new PlaylistData());
            baseAbstract.LoadPlaylist();
            Task<string> tsk = Task.Factory.StartNew<string>(() =>
            {

                int ctrl = 0;
                string str = null;
                for(int i=0;i<10; i++)
                {
                    str = str + "" + i;
                }
                return str;
            });
            string result = tsk.Result;
        }


        public void StartTask()
        {
            
            Action actObj = () => Console.WriteLine("");
            Task task = Task.Factory.StartNew(actObj);
            Task<string> stringdata = Task.Run(() =>
            {

                return "name";
            });
           var data= stringdata.Result;

            Func<string> result = delegate { return ""; };
        }

        public void Sorting()
        {
            List<PlaylistItems> playlistItems = new List<PlaylistItems>();
            playlistItems.Sort(delegate (PlaylistItems c1, PlaylistItems c2) { return c1.CompareTo(c2); });
            var oster = from o in playlistItems
                        group o by new { o.Playlistid } into sg
                        select new
                        {
                            id = sg.Key,
                            sum=sg.Sum(x=>x.Counter)
                        };

            Func<int,Task> rest = async(data) => 
            {
                await Task.Delay(100);
                
            };    
            
        }
    }

    public class PlaylistData : IPlaylistInstance
    {
        public List<PlaylistInstance> GetAllInstances()
        {
            return null;
        }
    }

    
}
