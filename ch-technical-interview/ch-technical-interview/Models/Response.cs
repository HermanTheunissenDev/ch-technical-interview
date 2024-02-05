using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ch_technical_interview.Models
{
    public class Response<T>
    {
        public string ResponseCode { get; set; }
        public T Data { get; set; }

        public Response(string responseCode, T data)
        {
            ResponseCode = responseCode;
            Data = data;
        }
    }
}