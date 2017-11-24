using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiAutoTest.Pages.Wiki
{
    public class WikiMainPage : Page
    {
        protected override string Url
        {
            get { return "https://uk.wikipedia.org/wiki/Головна_сторінка"; }
        }
    }
}
