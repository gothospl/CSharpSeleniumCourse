using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    class PageObjectTwo : IPageObject
    {
        public string PageName { get; set; }

        public PageObjectTwo()
        {
            PageName = "Page Name 2";
        }
    }
}
