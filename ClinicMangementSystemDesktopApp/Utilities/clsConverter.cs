using BackGroundOperations;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreProject.UI_Tools
{
    public class clsConverter
    {
        public static async void Convert(IF_Convertible obj, DataTable dt , string FileName, string TableName)
        {
            bool Result = await clsBackgroundWorker.Converter(obj, dt, FileName, TableName);

            if (Result)
            {
                MessageBox.Show($"{FileName} was created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{FileName} creation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
