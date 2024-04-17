using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using addressbook;
using Microsoft.EntityFrameworkCore;


namespace addressbook
{
    internal class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=contacts.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactId = 1, Name = "Jack Thompson", Address = "17 Maple Avenue", City = "Bristol", Country = "United Kingdom", PostCode = "BS1 5TF", Email = "jack.thompson@example.com", PhoneNumber = "+44 7890 123456" },
                new Contact { ContactId = 2, Name = "Olivia Walker", Address = "29 Rose Street", City = "Manchester", Country = "United Kingdom", PostCode = "M1 2LP", Email = "olivia.walker@example.com", PhoneNumber = "+44 7456 789012" },
                new Contact { ContactId = 3, Name = "Harry Clarke", Address = "8 Elm Grove", City = "London", Country = "United Kingdom", PostCode = "SW1A 1AA", Email = "harry.clarke@example.com", PhoneNumber = "+44 7543 210987" },
                new Contact { ContactId = 4, Name = "Sophia Patel", Address = "52 Oak Street", City = "Birmingham", Country = "United Kingdom", PostCode = "B1 1AA", Email = "sophia.patel@example.com", PhoneNumber = "+44 7654 321098" },
                new Contact { ContactId = 5, Name = "Thomas Wilson", Address = "11 Cedar Road", City = "Liverpool", Country = "United Kingdom", PostCode = "L1 1AA", Email = "thomas.wilson@example.com", PhoneNumber = "+44 7123 456789" },
                new Contact { ContactId = 6, Name = "Amelia Hughes", Address = "33 Birch Lane", City = "Leeds", Country = "United Kingdom", PostCode = "LS1 1AA", Email = "amelia.hughes@example.com", PhoneNumber = "+44 7243 567890" },
                new Contact { ContactId = 7, Name = "Daniel Clark", Address = "24 Pine Street", City = "Glasgow", Country = "United Kingdom", PostCode = "G1 1AA", Email = "daniel.clark@example.com", PhoneNumber = "+44 7374 567890" },
                new Contact { ContactId = 8, Name = "Lily Scott", Address = "7 Willow Avenue", City = "Edinburgh", Country = "United Kingdom", PostCode = "EH1 1AA", Email = "lily.scott@example.com", PhoneNumber = "+44 7980 123456" },
                new Contact { ContactId = 9, Name = "Jacob Green", Address = "15 Elm Street", City = "Cardiff", Country = "United Kingdom", PostCode = "CF1 1AA", Email = "jacob.green@example.com", PhoneNumber = "+44 7564 789012" },
                new Contact { ContactId = 10, Name = "Ava Turner", Address = "19 Maple Road", City = "Belfast", Country = "United Kingdom", PostCode = "BT1 1AA", Email = "ava.turner@example.com", PhoneNumber = "+44 7021 345678" },
                new Contact { ContactId = 11, Name = "Noah Carter", Address = "5 Oak Lane", City = "Newcastle", Country = "United Kingdom", PostCode = "NE1 1AA", Email = "noah.carter@example.com", PhoneNumber = "+44 7908 901234" },
                new Contact { ContactId = 12, Name = "Mia Roberts", Address = "22 Cedar Avenue", City = "Sheffield", Country = "United Kingdom", PostCode = "S1 1AA", Email = "mia.roberts@example.com", PhoneNumber = "+44 7789 567890" },
                new Contact { ContactId = 13, Name = "James Phillips", Address = "13 Pine Road", City = "Nottingham", Country = "United Kingdom", PostCode = "NG1 1AA", Email = "james.phillips@example.com", PhoneNumber = "+44 7234 567890" },
                new Contact { ContactId = 14, Name = "Charlotte Hall", Address = "9 Birch Street", City = "Leicester", Country = "United Kingdom", PostCode = "LE1 1AA", Email = "charlotte.hall@example.com", PhoneNumber = "+44 7878 901234" },
                new Contact { ContactId = 15, Name = "Ethan King", Address = "20 Willow Road", City = "Southampton", Country = "United Kingdom", PostCode = "SO1 1AA", Email = "ethan.king@example.com", PhoneNumber = "+44 7412 345678" },
                new Contact { ContactId = 16, Name = "Isabella Turner", Address = "10 Elm Lane", City = "Brighton", Country = "United Kingdom", PostCode = "BN1 1AA", Email = "isabella.turner@example.com", PhoneNumber = "+44 7965 678901" },
                new Contact { ContactId = 17, Name = "William Wright", Address = "14 Cedar Street", City = "Oxford", Country = "United Kingdom", PostCode = "OX1 1AA", Email = "william.wright@example.com", PhoneNumber = "+44 7575 123456" },
                new Contact { ContactId = 18, Name = "Grace Cooper", Address = "28 Maple Lane", City = "Cambridge", Country = "United Kingdom", PostCode = "CB1 1AA", Email = "grace.cooper@example.com", PhoneNumber = "+44 7354 678901" },
                new Contact { ContactId = 19, Name = "Benjamin Baker", Address = "16 Rose Avenue", City = "York", Country = "United Kingdom", PostCode = "YO1 1AA", Email = "benjamin.baker@example.com", PhoneNumber = "+44 7089 234567" },
                new Contact { ContactId = 1, Name = "Emily Davies", Address = "Emily Davies", City = "Ashford", Country = "United Kingdom", PostCode = "TN23 4TH", Email = "emily.davies@example.com", PhoneNumber = "+44 1234 567890" }
            );
        }
    }
}
