﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Configuration
{
    public class Client
    {
        public string Id { get; set; }

        public string Secret { get; set; }

        //MyApi1.com MyApi2.com
        public List<String> Audiences { get; set; }
    }
}
