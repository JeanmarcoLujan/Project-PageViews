using PageViewsProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace PageViewsProject.Application
{
    public class DescompressionApplication : IDescompressionApplication
    {
        public MemoryStream DecompressionPage(Stream stream)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (var zipStream = new GZipStream(stream, CompressionMode.Decompress))
            {
                zipStream.CopyTo(memoryStream);
                zipStream.Close();
                memoryStream.Position = 0;
                return memoryStream;
            }
        }
    }
}
