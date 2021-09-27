using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PageViewsProject.Domain.Entities;

namespace PageViewsProject.Application.Interfaces
{
    public interface IStartApplication
    {
        Task<List<Page>> GetInformationViews();

    }
}
