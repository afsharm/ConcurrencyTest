using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConcurrencyTest.Models
{
    public class CityLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Number { get; internal set; }
        public int Count { get; internal set; }
    }
}