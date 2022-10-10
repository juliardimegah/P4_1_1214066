using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214066
{
    public class Book_1214066: Product_1214066   
    {
        protected string pageCount;

        public Book_1214066(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get 
            {
                return this.pageCount; 
            }
            set 
            { 
                pageCount = value; 
            }
        }
    }
}
