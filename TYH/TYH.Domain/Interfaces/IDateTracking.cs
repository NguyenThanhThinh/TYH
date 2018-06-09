using System;

namespace TYH.Domain.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}
