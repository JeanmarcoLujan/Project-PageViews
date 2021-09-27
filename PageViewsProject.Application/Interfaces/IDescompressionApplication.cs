using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PageViewsProject.Application.Interfaces
{
    public interface IDescompressionApplication
    {
        MemoryStream DecompressionPage(Stream stream);
    }
}
