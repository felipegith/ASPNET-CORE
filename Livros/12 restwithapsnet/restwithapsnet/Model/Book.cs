﻿using restwithapsnet.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restwithapsnet.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {

        [Column("author")]
        public string Author { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }
}