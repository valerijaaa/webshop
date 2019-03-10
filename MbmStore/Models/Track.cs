﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Track
    {

        //properties
        public string Title { get; set; }
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }

        //constructors

        public Track()
        {
        }

        public Track(string title, string composer, TimeSpan length)
        {
            Title = title;
            Composer = composer;
            Length = length;
        }
    }
}