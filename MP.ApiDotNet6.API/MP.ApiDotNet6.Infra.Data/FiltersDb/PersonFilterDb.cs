using MP.ApiDotNet6.Infra.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.FiltersDb
{
    public class PersonFilterDb : PagedBaseRequest
    {
        public string? Name { get; set; }

    }
}
