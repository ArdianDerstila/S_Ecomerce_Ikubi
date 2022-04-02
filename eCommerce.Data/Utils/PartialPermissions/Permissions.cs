using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Data.Utils.PartialPermissions
{
    public static class Permissions
    {
        public static class User
        {
            public const string View = "User.View";
            public const string Add = "User.Add";
            public const string Edit = "User.Edit";
            public const string Delete = "User.Delete";
            public const string Profile = "User.Profile";
        }

        public static class Category
        {
            public const string View = "Category.View";
            public const string Add = "Category.Add";
            public const string Edit = "Category.Edit";
            public const string Delete = "Category.Delete";
        }

        public static class Product
        {
            public const string View = "Product.View";
            public const string Add = "Product.Add";
            public const string Edit = "Product.Edit";
            public const string Delete = "Product.Delete";
        }

        public static class Comment
        {
            public const string View = "Comment.View";
            public const string Add = "Comment.Add";
            public const string Edit = "Comment.Edit";
            public const string Delete = "Comment.Delete";
        }
    }
}
