using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PageViewsProject.Infraestructure.Interfaces
{
    public interface IDownloadInfraestructure
    {
        Task<Stream> GetPageStream(string url);
    }
}
