using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaveLabAgent.Resources;

namespace WaveLabServices.Resources
{
    public class Upload
    {
        ICollection<IFormFile> Files {get;set;}
        Procedure Procedure { get; set; }
    }
}
