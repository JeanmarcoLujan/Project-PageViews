using PageViewsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageViewsProject.Application.Interfaces
{
    public interface IListPageApplication
    {
        List<Page> ListPage(List<string> lines);
    }
}
