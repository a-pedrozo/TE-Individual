using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadJokesServer.Models
{
    public class Dad
    {
        public Dad()
        {

        }

        public Dad(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
