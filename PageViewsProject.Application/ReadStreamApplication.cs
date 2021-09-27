using PageViewsProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PageViewsProject.Application
{
    public class ReadStreamApplication : IReadStreamApplication
    {
        public async Task<List<string>> ReadStream(MemoryStream stream)
        {
            List<string> lines = new List<string>();

            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}
