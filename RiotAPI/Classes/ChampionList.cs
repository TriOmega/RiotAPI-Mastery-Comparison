﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MingweiSamuel.Camille;

namespace RiotAPI
{
    class ChampionList
    {
        public Dictionary<string, Champion> Data { get; set; } 
    }
}
