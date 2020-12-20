using CefSharp;
using CefSharp.WinForms;

namespace CefSharp.Example.Handlers
{
    public class MyLifeHandler : ILifeSpanHandler
    {
        //event that receive url popup
        /*public event  popup_request;*/

        bool ILifeSpanHandler.OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            //get url popup
            /* if (this.popup_request != null)
                 this.popup_request(targetUrl);
 */
            //stop open popup window
            browser.MainFrame.LoadUrl(targetUrl);
            newBrowser = null;
            return true;
        }
        bool ILifeSpanHandler.DoClose(IWebBrowser browserControl, IBrowser browser)
        { return false; }

        void ILifeSpanHandler.OnBeforeClose(IWebBrowser browserControl, IBrowser browser) { }

        void ILifeSpanHandler.OnAfterCreated(IWebBrowser browserControl, IBrowser browser) { }
    }
}