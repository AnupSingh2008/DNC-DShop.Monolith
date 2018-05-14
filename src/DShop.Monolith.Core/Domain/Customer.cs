using System;

namespace DShop.Monolith.Core.Domain
{
    public class Customer : EntityBase, IAggregateRoot
    {
        public string Email { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Address { get; protected set; }
        public string Country { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public bool Completed => CompletedAt.HasValue;
        public DateTime? CompletedAt { get; protected set; }

        protected Customer()
        {
        }

        public Customer(Guid id, string email)
        {
            Id = id;
            Email = email;
            CreatedAt = DateTime.UtcNow;
        }

        public void Complete(string firstName, string lastName, 
            string address, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Country = country;
            CompletedAt = DateTime.UtcNow;
        }
    }
}