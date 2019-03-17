using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReviewSite.Models
{
    public class ReviewModel
    {
        public Guid ReviewId { get; set; }
        public string ReviewerName { get; set; }
        public string ProductName { get; set; }

        public int[] ReviewScore = new int[]
           {
               1,2,3,4,5,6,7,8,9,10
           };

    }
}