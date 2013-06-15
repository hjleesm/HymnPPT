using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HymnPPT
{
    class Hymns
    {
        private string Seq;
        private string Title;
        private string Lyric;

        public Hymns()
        {
            Seq = "";
            Title = "";
            Lyric = "";
        }

        public Hymns(string _Seq, string _Title, string _Lyric)
        {
            Seq = _Seq;
            Title = _Title;
            Lyric = _Lyric;
        }

        public string _Seq
        {
            set
            {
                Seq = value;
            }
            get
            {
                return Seq;
            }
        }
        public string _Title
        {
            set
            {
                Title = value;
            }
            get
            {
                return Title;
            }
        }
        public string _Lyric
        {
            set
            {
                Lyric = value;
            }
            get
            {
                return Lyric;
            }
        }
    }
}
