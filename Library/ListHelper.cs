using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Library
{
    public static class ListHelper
    {

        public static List<SelectListItem> GetEntityIquery<T>(List<T> records, int idSelect) where T : class
        {
            List<SelectListItem> options = new List<SelectListItem>();
            Boolean bSelected = false;

            foreach (T item in records)
            {
                string key = "";
                string text = "";
                foreach (var prop in item.GetType().GetProperties())
                {

                    if (prop.Name.Equals("Id"))
                    {
                        key = prop.GetValue(item, null).ToString();
                        bSelected = true;
                    }
                    else if (prop.Name.Equals("Name"))
                    {
                        text = prop.GetValue(item, null).ToString();
                    }
                }

                if (idSelect > 0 && bSelected)
                {
                    options.Add(new SelectListItem { Value = key, Text = text, Selected = true });

                }else
                {
                    options.Add(new SelectListItem { Value = key, Text = text });
                }
            }

            return options;

        }

        public static List<SelectListItem> GetEntityIquery<T>(List<T> records, string field, int idSelect) where T : class
        {
            List<SelectListItem> options = new List<SelectListItem>();
            Boolean bSelected = false;

            foreach (T item in records)
            {
                string key = "";
                string text = "";
                foreach (var prop in item.GetType().GetProperties())
                {

                    if (prop.Name.Equals("Id"))
                    {
                        key = prop.GetValue(item, null).ToString();
                        bSelected = true;
                    }
                    else if (prop.Name.Equals(field))
                    {
                        text = prop.GetValue(item, null).ToString();
                    }
                }

                if (idSelect > 0 && bSelected)
                {
                    options.Add(new SelectListItem { Value = key, Text = text, Selected = true });

                }
                else
                {
                    options.Add(new SelectListItem { Value = key, Text = text });
                }
            }

            return options;

        }
    }
}
