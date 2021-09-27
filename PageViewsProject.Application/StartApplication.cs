using PageViewsProject.Application.Interfaces;
using PageViewsProject.Domain.Entities;
using PageViewsProject.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PageViewsProject.Application
{
    public class StartApplication : IStartApplication
    {
        private readonly IUrlApplication urlApplication;
        private readonly IDownloadInfraestructure downloadInfraestructure;
        private readonly IDescompressionApplication descompressionApplication;
        private readonly IReadStreamApplication readStreamApplication;
        private readonly IListPageApplication listPageApplication;
        private readonly IResultPageViewApplication resultPageViewApplication;
        private readonly IOutputResultApplication outputResultApplication;

        public StartApplication( IUrlApplication urlApplication, IDownloadInfraestructure downloadInfraestructure, IDescompressionApplication descompressionApplication, IReadStreamApplication readStreamApplication, IListPageApplication listPageApplication, IResultPageViewApplication resultPageViewApplication, IOutputResultApplication outputResultApplication)
        {
            this.urlApplication = urlApplication;
            this.downloadInfraestructure = downloadInfraestructure;
            this.descompressionApplication = descompressionApplication;
            this.readStreamApplication = readStreamApplication;
            this.listPageApplication = listPageApplication;
            this.resultPageViewApplication = resultPageViewApplication;
            this.outputResultApplication = outputResultApplication;
        }
        public async Task<List<Page>> GetInformationViews()
        {
            try {
                Console.WriteLine("Process started");

                Console.WriteLine("Start generate url");
                // 0 - generate url for pages
                List<string> urls = this.urlApplication.GetUrls();
                Console.WriteLine("Finish generate url");

                List<Page> pagesInformation = new List<Page>();

                foreach (string url in urls)
                {
                    Console.WriteLine("Downloading from Url: {0} ", url);
                    // 1 - download page
                    Stream stream = await this.downloadInfraestructure.GetPageStream(url);

                    // 2 - Descompression page
                    MemoryStream memoryStream = this.descompressionApplication.DecompressionPage(stream);

                    //3 - Read stream
                    List<string> lines = await this.readStreamApplication.ReadStream(memoryStream);

                    //4 - intances object of page
                    List<Page> pageObj = this.listPageApplication.ListPage(lines);

                    //5 - join pages
                    pagesInformation.AddRange(pageObj);
                }

                Console.WriteLine("Finished download");

                Console.WriteLine("Print results...");
                // 6 - Calculare result following SQL statemente of coding assignment
                List<Page> pageViews = this.resultPageViewApplication.GetPageViews(pagesInformation);

                this.outputResultApplication.PrintResult(pageViews);

                

                return pageViews;
            }
            catch (Exception error)
            {
                Console.WriteLine("An error has occurred: {0}", error.Message);
                return null;
            }

            
        }
    }
}
