using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.RaffleUC
{
    class Raffle
    {
        public byte RaffleId { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime RaffleDate { get; set; }
        public Boolean Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
