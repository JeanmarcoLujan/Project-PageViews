using PageViewsProject.Application.Interfaces;
using PageViewsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageViewsProject.Application
{
    public class ListPageApplication : IListPageApplication
    {
        public List<Page> ListPage(List<string> lines)
        {
            return lines.Select(line =>
            {
                string[] row = line.Split(" ", 4);
                return (row.Length == 4) ? new Page() { DomainCode = row[0], PageTitle = row[1], CountView = int.Parse(row[2]) }: null;
            })
            .Where(x => x != null)
            .ToList();
        }
    }
}
