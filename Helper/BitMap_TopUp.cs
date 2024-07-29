using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows;
using System.Web;
using System.Configuration;

namespace ToolsApp.Helper
{
    public class BitMap_TopUp
    {
        public static string fullPath = "";
        public static Bitmap Load_data(string a)
        {
            try
            {
                Bitmap TopUp_Image;
                string basePath = ConfigurationManager.AppSettings["FileBasePath"];
                string absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, basePath, a);
                fullPath = absolutePath.Replace("\\bin\\Debug", "");
                // Kiểm tra tệp có tồn tại hay không
                if (File.Exists(fullPath))
                {
                    TopUp_Image = (Bitmap)Bitmap.FromFile(fullPath);
                }
                else
                {
                    throw new FileNotFoundException("File not found: " + fullPath);
                }

                return TopUp_Image;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine("Error loading image: " + ex.Message);
                return null; // Đảm bảo trả về null trong trường hợp lỗi
            }
        }
        public static string path(string a)
        {
            string basePath = ConfigurationManager.AppSettings["FileBasePath"];
            string absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, basePath,a);
            fullPath = absolutePath.Replace("\\bin\\Debug", "");
            return fullPath;
        }
    }
}