using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Dtos
{
    public class PurchaseDetailDto
    {
        public int Id { get; set; }

        public string Person { get; set; }

        public string Product { get; set; }

        public DateTime Date { get; set; }
    }
}
