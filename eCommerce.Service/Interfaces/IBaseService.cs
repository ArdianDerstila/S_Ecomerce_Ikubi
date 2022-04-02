using eCommerce.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Service.Interfaces
{
    public interface IBaseService
    {
        List<Category> GetCategories();
    }
}
