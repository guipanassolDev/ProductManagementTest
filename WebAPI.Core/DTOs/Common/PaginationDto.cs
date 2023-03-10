using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Enums;

namespace WebAPI.Core.DTOs.Common
{
    public class PaginationDto
    {
        [DefaultValue(0)]
        public int Skip { get; set; }

        [DefaultValue(10)]
        public int Take { get; set; }

        public SortType SortDirection { get; set; }

        public string SortBy { get; set; }
    }
}
