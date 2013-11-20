using System;
using System.Collections.Generic;
using System.Linq;

namespace CraftyKnockoutMvc.Models
{
    public class KnockoutIslandModel
    {
        public Event Event { get; set; }

        public IEnumerable<FamousCoder> PossibleSpeakers { get; set; }
    }
}
