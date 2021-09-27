using PageViewsProject.Application.Interfaces;
using PageViewsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageViewsProject.Application
{
    public class UrlApplication : IUrlApplication
    {
        private readonly MyConfiguration myConfiguration;

        public UrlApplication(MyConfiguration myConfiguration)
        {
            this.myConfiguration = myConfiguration;
        }
        public List<string> GetUrls()
        {
            List<string> linksToDownload = new List<string>();

            for (int i = 0;  i < this.myConfiguration.Hour;  i++)
            {
                DateTime dateTime = DateTime.Now.AddHours(-1*i);
                string url = this.myConfiguration.Url +  dateTime.ToString("/yyyy/yyyy-MM/") + "pageviews-" + dateTime.ToString("yyyyMMdd-HH")+"0000.gz";
                linksToDownload.Add(url);
            }

            return linksToDownload;
        }
    }
}
