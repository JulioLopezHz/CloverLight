using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.RaffleUC
{
    class Client
    {
        public int ClientId { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Cell { get; set; }
        public String Email { get; set; }
        public String Observations { get; set; }
        public Boolean Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
