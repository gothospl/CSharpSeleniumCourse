using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    class PageObjectOne : IPageObject
    {
        public string PageName { get; set; }

        public PageObjectOne()
        {
            PageName = "Page Name 1";
        }
    }
}
