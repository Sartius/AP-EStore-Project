using System;
using System.Collections.Generic;
using System.Text;

namespace ES_DTO
{
    class SearchDtoModel
    {
        public string SearchString { get; set; }
        public Enumerations.Category Category { get; set; }
        public Enumerations.Gender Gender { get; set; }
        public Enumerations.Condition Condition { get; set; }
        public Enumerations.SortBy SortBy { get; set; }
        public bool FreeShipping { get; set; }

        
    }
}
