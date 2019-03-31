using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        //field
        private List<Track> tracks;

        //properties
        public List<Track> Tracks { get { return tracks; } }
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }

        //constructors
        public MusicCD() : base()
        {
        }

        public MusicCD(int productId, string artist, string title, decimal price, short released, string imageUrl)
             : base(productId, title, price, imageUrl)
        {
            ProductId = productId;
            Artist = artist;
            Label = Label;
            Released = released;
            tracks = new List<Track>();
        }

        //methods

        public void AddTrack(Track track)
        {
            tracks.Add(track);
        } 

        public TimeSpan GetPlayingTime()
        {
            double sumOfTotalSeconds = tracks.Sum(track => track.Length.TotalSeconds);
            return TimeSpan.FromSeconds(sumOfTotalSeconds);
        }
        


    }
}