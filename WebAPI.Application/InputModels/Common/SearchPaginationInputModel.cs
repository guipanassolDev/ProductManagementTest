using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.InputModels.Common
{
    public class SearchPaginationInputModel : PaginationInputModel
    {
        public string SearchTerms { get; set; }
    }
}
