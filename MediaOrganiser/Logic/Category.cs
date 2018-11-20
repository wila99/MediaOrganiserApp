using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace MediaOrganiser.Logic
{
    public class Category
    {
        public List<string> categories = new List<string>();
        XElement root;
        XDocument xDocument = XDocument.Load("Data/Data.xml");

        public bool AddCategory(string userCategory)
        {
            root = XElement.Load(@"Data\Data.xml");
            //Check to see if category exists
            foreach (XElement xe in root.Descendants("category"))
            {
                if (xe.Value == userCategory)
                {
                    return false;
                }
            }

            root.Add(new XElement("category", userCategory));
            root.Save("Data/Data.xml");
            return true;
        }


        public void EditCategory(string newCategory, string previousCategory)
        {
            root = XElement.Load(@"Data\Data.xml");
            foreach (XElement xe in root.Descendants("category"))
            {
                if (xe.Value == previousCategory)
                {
                    xe.Value = newCategory;
                }
            }
            root.Save("Data/Data.xml");
        }


        public void DeleteCategory(string category)
        {
            root = XElement.Load(@"Data/Data.xml");
            foreach (XElement xe in root.Descendants("category"))
            {
                if (xe.Value == category)
                {
                    xe.RemoveNodes();
                }
            }
            root.Save("Data/Data.xml");

        }



        public List<string> GetCategories()
        {
            if (categories.Count >= 1)
            {
                categories.Clear();
            }
            root = XElement.Load(@"Data\Data.xml");
            foreach (XElement xe in root.Descendants("category"))
            {
                if (!(string.IsNullOrEmpty(xe.Value)))
                {
                    categories.Add(xe.Value);
                }
            }
            return categories;

        }
    }
}
