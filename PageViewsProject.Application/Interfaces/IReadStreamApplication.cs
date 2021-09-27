using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PageViewsProject.Application.Interfaces
{
    public interface IReadStreamApplication
    {
        Task<List<string>> ReadStream(MemoryStream stream);
    }
}
