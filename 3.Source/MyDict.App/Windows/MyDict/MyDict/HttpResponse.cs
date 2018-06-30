using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict
{
    public class HttpResponse
    {
        public int Status { get; set; }
        public List<List<string>> Data { get; set; }

        public static implicit operator HttpResponse(Task<HttpResponse> v)
        {
            throw new NotImplementedException();
        }
    }
}
