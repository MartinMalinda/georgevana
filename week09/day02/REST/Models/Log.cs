using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Endpoint { get; set; }
        public string Data { get; set; }

        public Log(string endpoint, string data)
        {
            CreatedAt = DateTime.Now;
            Endpoint = endpoint;
            Data = data;
        }
    }
}
