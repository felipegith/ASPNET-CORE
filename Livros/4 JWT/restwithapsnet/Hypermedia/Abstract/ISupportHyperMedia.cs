﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restwithapsnet.Hypermedia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
