﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class HIstoryConsumerPoint
    {
        public Guid Id { get; set; }
        public Guid ConsumerPointId { get; set; }
        public Guid FormulaId { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public ConsumerPoint ConsumerPoints { get; set; }
        public Formula Formulas { get; set; }

    }
}
