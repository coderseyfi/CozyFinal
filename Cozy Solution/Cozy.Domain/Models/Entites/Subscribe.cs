using Cozy.Domain.AppCode.Infrastructure;
using System;

namespace Cozy.Domain.Models.Entites
{
    public class Subscribe:BaseEntity
    {
        public string Email { get; set; }
        public bool IsApproved { get; set; } = false;
        public DateTime? ApprovedDate { get; set; }
    }
}
