using System;

namespace addressbook

{
    public class Contact()
    {
        // getters and setters / properties
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        //navigation prim/ foreng key.
    }
}
