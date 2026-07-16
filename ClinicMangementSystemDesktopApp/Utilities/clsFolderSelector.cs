using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreProject.UI_Tools
{
    public class clsFolderSelector
    {
        public static string _SelectFolderPath()
        {
            string FolderPath = "";
            using (FolderBrowserDialog diag = new FolderBrowserDialog())
            {
                diag.Description = "Select a folder";
                diag.ShowNewFolderButton = true;

                if (diag.ShowDialog() == DialogResult.OK)
                {
                    FolderPath = diag.SelectedPath;
                }
                return FolderPath;
            }
        }

    }
}
