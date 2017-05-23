using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Outlook;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace encrypt_c
{
    public partial class EncryptButton
    {
        private void EncryptButton_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void EncryptBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Application app = new Outlook.Application();
            Outlook.MailItem mailItem = app.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "Encrypt: ";
            mailItem.Display(false);
            
        }
    }
}
