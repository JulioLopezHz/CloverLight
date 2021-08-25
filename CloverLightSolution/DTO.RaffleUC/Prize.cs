using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.RaffleUC
{
    class Prize
    {
        public byte PrizeId { get; set; }
        public byte RaffleId { get; set; }
        public String Product { get; set; }
        public Boolean Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
