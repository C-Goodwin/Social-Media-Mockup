﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class ReplyDetail
    {
        public int ReplyId { get; set; }
        public string Text { get; set; }
        public Guid Author { get; set; }

    }
}
