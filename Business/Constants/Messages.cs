using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is added";
        public static string ProductNameInvalid = "Product Name is invalid!";
        public static string MaintenanceTime = "System under Maintanence";
        public static string ProductListed = "Products are listed";
        public static string ProductCountOfCategoryError = "Limit Exceeded";
        public static string ProductNameAlreadyExists = "There is already a product with this name";
        internal static string CategoryNumberExceeds = "Category Limit Exceeded";
    }
}
