using System;
using System.Collections.Generic;
using System.Text;

namespace PageViewsProject.Domain.Entities
{
    public class Page
    {
        public string DomainCode { get; set; }
        public string PageTitle { get; set; }
        public int CountView { get; set; }
    }
}
