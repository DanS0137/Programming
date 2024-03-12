using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private string Name { get; set; }
        private string Performer { get; set; }
        private int _duration;

        public int Duration
        {
            get => _duration;
            set
            {
                if (value < 0) throw new ArgumentException();
                _duration = value;
            }
        }

        public Song(string name, string performer, int duration)
        {
            Name = name;
            Performer = performer;
            Duration = duration;
        }
        public Song() { }
    }
}
