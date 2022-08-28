﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        
        public string BlogTitle { get; set; }

        public string BlogImage { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogContent { get; set; }
        //public bool ButtonOnOf { get; set; }
        //public string ButtonTitle { get; set; }
       // public string ButtonUrl { get; set; }

        //public int BlogRating { get; set; }
        //public int CategoryID { get; set; }
        //public virtual Category Category { get; set; }
        //public bool BlogStatus { get; set; }



        public int AuthorID { get; set; }
        //public virtual Author Author { get; set; }

    }
}
