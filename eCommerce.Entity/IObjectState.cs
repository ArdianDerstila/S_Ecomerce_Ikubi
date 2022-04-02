using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Entity
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState State { get; set; }
    }
}
