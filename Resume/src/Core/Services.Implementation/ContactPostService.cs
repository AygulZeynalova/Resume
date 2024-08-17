using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Resume.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class ContactPostService : IContactPostService
    {
        private readonly DbContext db;

        public ContactPostService(DbContext db)
        {
            this.db = db;
        }
        public string Add(string name, string email, string subject, string message)
        {
            var post = new ContactPost { Name = name, Email = email, Subject = subject, Message = message, CreatedAt = DateTime.Now };

            db.Set<ContactPost>().Add(post);
            db.SaveChanges();

            return message = "Your message has been received!";
            
        }
    }
}
