using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CraftyKnockoutMvc.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name="Name of Event")]
        public string EventName { get; set; }

        [Display(Name = "Event Location")]
        public string Location { get; set; }

        [Display(Name = "Date of Event")]
        [DisplayFormat(DataFormatString="{0:D}", ApplyFormatInEditMode=true)]
        public DateTime? DateOfEvent { get; set; }

        public IList<FamousCoder> Speakers { get; set; }
    }
}