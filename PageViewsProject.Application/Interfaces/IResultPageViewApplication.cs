using PageViewsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageViewsProject.Application.Interfaces
{
    public interface IResultPageViewApplication
    {
        List<Page> GetPageViews(List<Page> pageViews);
    }
}
