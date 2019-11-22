using System;
namespace ZadachiData.Entities
{
    public class Zadacha
    {
        public Zadacha()
        {
            CreationDate=DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public DateTime CreationDate { get; set; }
    }
}