using System;
using Ders2_Odev4.Abstract;
namespace Ders2_Odev4.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public long NationalityId { get; set; }

    }

}