﻿using System;

namespace ContactApp.Domain
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public Contact Contacts { get; set; }
        public Guid ContactId { get; set; }
    }
}
