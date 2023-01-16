using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Responses
{
    public class ResponseCreate<Tentity>
    {
        public int StatusCode { get; set; }
        public Tentity Data { get; set; }
        public string? Message { get; set; } 
    }
}
