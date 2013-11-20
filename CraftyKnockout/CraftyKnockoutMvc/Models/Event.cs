using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraftyKnockoutMvc.Models
{
    public class Event
    {
        public string EventName { get; set; }

        public string Location { get; set; }

        public DateTime? DateOfEvent { get; set; }

        public IList<FamousCoder> Speakers { get; set; }
    }
}