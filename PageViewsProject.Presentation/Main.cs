using PageViewsProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageViewsProject.Presentation
{
    class Main
    {
        private readonly IStartApplication _pageViewService;
        public Main(IStartApplication pageViewService)
        {
            _pageViewService = pageViewService;
        }

        public void Run()
        {
            Task.WaitAll(_pageViewService.GetInformationViews());
        }
    }
}
