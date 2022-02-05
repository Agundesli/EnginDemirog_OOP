using Ders2_Odev5_Uygulama.Abstract;
using System;

namespace Ders2_Odev5_Uygulama.Entities

{
    public class Gamer :Cooperate, IEntity
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public long NationalityId { get; set; }
        public int BirthDate { get; set; }
    }
}
