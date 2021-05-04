using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemoact.Models
{
    public class TodoItem
    {
        public long Id { get; set; }//this is id
        public string Name { get; set; }//this is name
        public bool IsComplete { get; set; }
    }
}
