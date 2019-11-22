using System.Collections.Generic;
using ZadachiData.Entities;

namespace ZadachiWeb.Models
{
    public class ZadachiViewModel
    {
        public ZadachiViewModel(IEnumerable<Zadacha> zadachi)
        {
            Zadachi=zadachi;
        }
    public IEnumerable<Zadacha> Zadachi {get;set;}
    }
}