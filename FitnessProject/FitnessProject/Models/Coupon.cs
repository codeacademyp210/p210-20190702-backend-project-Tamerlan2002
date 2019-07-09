using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessProject.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string CouponName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}