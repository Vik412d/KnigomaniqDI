﻿namespace Knigomaniq.Models
{
    public class Shopping
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User Users { get; set; }

        public int BookId { get; set; }
        public Book Books { get; set; }

        public DateTime RegisterOn { get; set; }

    }
}
