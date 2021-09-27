using PageViewsProject.Application.Interfaces;
using PageViewsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageViewsProject.Application
{
    public class ResultPageViewApplication : IResultPageViewApplication
    {
        public List<Page> GetPageViews(List<Page> pageViews)
        {
            return pageViews
                .GroupBy(x => new { x.DomainCode, x.PageTitle })
                .Select(y => new Page
                {
                    DomainCode = y.First().DomainCode,
                    PageTitle = y.First().PageTitle,
                    CountView = y.Sum(z => z.CountView),
                })
                .OrderByDescending(x => x.CountView)
                .Take(100).ToList();
        }
    }
}
