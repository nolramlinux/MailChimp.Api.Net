﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class Goal
    {
        public int goal_id { get; set; }
        public string @event { get; set; }
        public string last_visited_at { get; set; }
        public string data { get; set; }
    }
}
