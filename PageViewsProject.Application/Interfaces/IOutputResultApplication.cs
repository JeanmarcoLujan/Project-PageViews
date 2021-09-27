using PageViewsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageViewsProject.Application.Interfaces
{
    public interface IOutputResultApplication
    {
        void PrintResult(List<Page> pages);
        void PrintLine();
        void PrintRow(params string[] columns);
        string AlignCentre(string text, int width);

    }
}
