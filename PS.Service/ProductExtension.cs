using PS.Domain;
using System;


namespace PS.Service
{
    public static class ProductExtension
    {
        public static void UpperName(this ManagerProduct mp, Product p)
        {
            p.Name = p.Name.ToUpper();
        }

        public static Boolean InCategory(this ManagerProduct mp, Product p, Category c)
        {
            return p.MyCategory.CategoryId.Equals(c.CategoryId);

        }
    }
}