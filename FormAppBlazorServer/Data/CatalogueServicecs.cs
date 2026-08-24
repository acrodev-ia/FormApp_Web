using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FormAppBlazorServer.Data
{
    public class CatalogueService
    {
        public CatalogueService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "datas", "cataloguefull.json"); }
        }

        public async Task<IEnumerable<Rootobjectcatalogue>> GetCatalogueAsync()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return await Task.FromResult(JsonSerializer.Deserialize<Rootobjectcatalogue[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }));
            }
        }
    }
}
