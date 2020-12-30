using System;
using CefSharp;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Diagnostics;

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
        model.AddItem((CefMenuCommand)113, "Copy");
        model.AddItem((CefMenuCommand)100, "Back");
        model.AddItem((CefMenuCommand)101, "Forward");
        model.AddItem((CefMenuCommand)102, "Reload");
        model.AddItem((CefMenuCommand)103, "Reload No Cache");
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
            if (parameters.LinkUrl.Length > 0)
            {

                Clipboard.SetText(parameters.LinkUrl);

            }
            if (parameters.MediaType == ContextMenuMediaType.Image)
            {
                Clipboard.SetText(parameters.SourceUrl);
                
                string subPath = @"C:\temp";

                string fn = @"C:\temp\image.jpeg";

                System.IO.Directory.CreateDirectory(subPath);

                SaveImage(parameters.SourceUrl, fn, ImageFormat.Jpeg);

                Process.Start(fn);
            }
            MessageBox.Show("Saved as Image");
            return true;
        }
        if (commandId == (CefMenuCommand)113) // Copy
        {

            if (parameters.LinkUrl.Length > 0)
            {
                Clipboard.SetText(parameters.LinkUrl);
            }
            if (parameters.MediaType == ContextMenuMediaType.Image)
            {
                Clipboard.SetText(parameters.SourceUrl);
            }
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
    public void SaveImage(string imageUrl, string filename, ImageFormat format)
    {
        System.Net.WebClient client = new WebClient();
        System.IO.Stream stream = client.OpenRead(imageUrl);
        Bitmap bitmap; bitmap = new Bitmap(stream);

        if (bitmap != null)
        {
            bitmap.Save(filename, format);
        }

        stream.Flush();
        stream.Close();
        client.Dispose();
    }

}