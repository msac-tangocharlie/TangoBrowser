using System;
using CefSharp;
using System.Windows.Forms;
public class MyCustomMenuHandler : IContextMenuHandler
{
    public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
    {
        // Remove any existent option using the Clear method of the model
        //
        //model.Clear();

        

        // You can add a separator in case that there are more items on the list
        if (model.Count > 0)
        {
            model.AddSeparator();
        }


        // Add a new item to the list using the AddItem method of the model
        model.AddItem((CefMenuCommand)26504, "Save As");
        model.AddItem((CefMenuCommand)26505, "Show DevTools");
        

        // Add a separator


        // Add another example item

    }

    public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
    {
        // React to the first ID (show dev tools method)
        if (commandId == (CefMenuCommand)26505)
        {
            browser.GetHost().ShowDevTools();
            return true;
        }
        if (commandId == (CefMenuCommand)26504)
        {
            MessageBox.Show("Save as feature");
            return true;
        }


        // Any new item should be handled through a new if statement


        // Return false should ignore the selected option of the user !
        return false;
    }

    public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
    {

    }

    public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
    {
        return false;
    }
}