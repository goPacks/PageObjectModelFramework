using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.WebAbstraction.Core
{
    public interface ICoreLoginPage
    {

        void NavigateTo(string URL);
        void EnterCredentials(string username, string passWord);

        void CheckPageTitle(string pageTitle);

        void ClickLogin();

        void CloseAllTabs();


    }
}
