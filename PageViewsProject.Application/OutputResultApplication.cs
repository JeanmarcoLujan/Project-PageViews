using PageViewsProject.Application.Interfaces;
using PageViewsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageViewsProject.Application
{
    public class OutputResultApplication : IOutputResultApplication
    {
        static int tableWidth = 100;
        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        public void PrintResult(List<Page> pages)
        {
            try
            {
                PrintLine();
                PrintRow("#", "domain_code", "page_title", "max_count_views");
                PrintLine();
                int index = 1;
                foreach (var page in pages)
                {
                    PrintRow(index.ToString(), page.DomainCode, page.PageTitle, page.CountView.ToString());
                    index++;
                }
                PrintLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred during result print");
            }
        }
    }
}
