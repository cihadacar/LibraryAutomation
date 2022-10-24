using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public string BookName { get; set; }
        public int PageCount { get; set; }
        public int PrintingCount { get; set; }

    }
}
