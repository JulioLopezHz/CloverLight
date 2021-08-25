using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.RaffleUC
{
    class Winner
    {
        public byte WinnerId { get; set; }
        public int TicketId { get; set; }
        public byte PrizeId { get; set; }
        public Boolean Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
