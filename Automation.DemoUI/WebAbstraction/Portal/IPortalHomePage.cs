using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.WebAbstraction.Portal
{
    public interface IPortalHomePage
    {


        void ClickMenu(string menu);

        void ClickSubMenu(string subMenu);

    }
}
