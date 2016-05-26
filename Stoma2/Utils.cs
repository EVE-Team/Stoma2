﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoma2
{
    class Utils
    {
        public static T SetupForm<T>(T form) where T : Form
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            return form;
        }

        public static void SetPanelForm(Panel panel, Control form)
        {
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        public static Control GetPanelForm(Panel panel)
        {
            if (panel.Controls.Count != 1)
                throw new Exception("Unexpected control count");
            return panel.Controls[0];
        }

        public static string[] SliceArray(string[] array, int[] indices)
        {
            List<string> result = new List<string>();

            foreach (int index in indices)
            {
                result.Add(array[index]);
            }

            return result.ToArray();
        }

        public static bool IsInt64(object obj)
        {
            return obj.GetType().FullName == "System.Int64";
        }

        public static string DateToString(DateTime date)
        {
            if (date != DateTime.MinValue)
            {
                return date.ToString("d");
            }
            else
            {
                return "";
            }
        }
    }

    class DateUtils
    {
        public static readonly string INNER_DATE_FORMAT = "yyyy-MM-dd HH:mm";
        public static readonly string EXTERNAL_DATE_FORMAT = "dd-MM-yyyy HH:mm";
        public static readonly string WITHOUT_TIME_DATE_FORMAT = "dd-MM-yyyy";
        
        public static string GetCurrentTimestamp()
        {
            return DateTime.Now.ToString(INNER_DATE_FORMAT);
        }

        public static string ToDateFormat(string date, string DATE_FORMAT)
        {
            string res;
            try
            {
                res = DateTime.Parse(date).ToString(DATE_FORMAT);
            }
            catch (Exception)
            {
                res = "";
            }
            return res;
        }
    }
}
