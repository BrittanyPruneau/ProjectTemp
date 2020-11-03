using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectPage1and2.Models
{
    public class ToolsResourcesAdvice
    {
        // Fields & Properties

        public int toolID { get; set; }
        [Required(ErrorMessage="What is the name of the tool you are gifting.")]
        public string toolName {get; set;}

        [Required(ErrorMessage ="You must let us know who you want your tool to be gifted to.")]
        public string giftedTo { get; set; }
        public string giftedFrom { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }

        public bool received { get; set; }




        // Constructors

        // Methods 
    }
}
