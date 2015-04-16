﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrumproject.Logic.Entities
{
    public class AdvancePayments
    {
        public int PrepayId { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    } 


}

