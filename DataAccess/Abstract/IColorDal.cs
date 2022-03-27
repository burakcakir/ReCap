using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using Core.Entities;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}
