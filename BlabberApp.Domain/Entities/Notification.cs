using System;

namespace BlabberApp.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public String Link { get; set; }
        public String Message { get; set; }
    }
}