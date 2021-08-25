using System;

namespace DTO.RaffleUC
{
    public class UserUC
    {
        public byte UserUCId { get; set; }
        public String UserName { get; set; }
        public String Pass_word { get; set; }
        public DateTime LastAccess { get; set; }
        public Boolean Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
