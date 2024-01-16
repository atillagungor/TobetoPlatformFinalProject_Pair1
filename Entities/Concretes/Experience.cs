﻿using Core.Entities;

namespace Entities.Concretes
{
    public class Experience:Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string OrganizationName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public string City { get; set; }
        public DateTime StartOfDate { get; set; }
        public DateTime EndOfDate { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }
}
