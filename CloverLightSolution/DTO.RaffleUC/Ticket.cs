using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.RaffleUC
{
    class Ticket
    {
        public int TicketId { get; set; }
        public byte RaffleId { get; set; }
        public int ClientId { get; set; }
        public Boolean Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
