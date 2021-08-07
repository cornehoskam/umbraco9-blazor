using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Umbraco9_Blazor.Models
{
    public class PublishEventModel
    {
        public string ModelAlias { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
