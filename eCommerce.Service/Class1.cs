using eCommerce.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Service
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState State { get; set; }
    }
}
