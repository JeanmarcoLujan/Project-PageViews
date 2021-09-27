using Flurl.Http;
using PageViewsProject.Infraestructure.Interfaces;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PageViewsProject.Infraestructure
{
    public class DownloadInfraestructure : IDownloadInfraestructure
    {
        public async Task<Stream> GetPageStream(string url)
        {
            //Send a GET request to the specified Uri and return the response body as a stream in an asynchronous operation.
            return await url.WithTimeout(TimeSpan.FromMinutes(10)).GetStreamAsync().ConfigureAwait(continueOnCapturedContext: false); ;

        }
    }
}
