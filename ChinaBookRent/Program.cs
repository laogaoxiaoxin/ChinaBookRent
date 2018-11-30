﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace ChinaBookRent
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class INIhelp
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

        //ini文件名称
        private static string inifilename = "Config.ini";
        //获取ini文件路径
        private static string inifilepath = Directory.GetCurrentDirectory() + "\\" + inifilename;

        public static string GetValue(string key)
        {
            StringBuilder s = new StringBuilder(1024);
            GetPrivateProfileString("CONFIG", key, "", s, 1024, inifilepath);
            return s.ToString();
        }


        public static void SetValue(string key, string value)
        {
            try
            {
                WritePrivateProfileString("CONFIG", key, value, inifilepath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
