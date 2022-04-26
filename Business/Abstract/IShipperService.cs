using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IShipperService
    {
        IDataResult<List<Shipper>> GetAll();
        IDataResult<Shipper> GetByShipperId(int shipperId);
        IResult Add(Shipper shipper);
        IResult Delete(Shipper shipper);
        IResult Update(Shipper shipper);

    }
}
