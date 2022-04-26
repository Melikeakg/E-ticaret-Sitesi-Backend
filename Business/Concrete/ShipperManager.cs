using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ShipperManager : IShipperService
    {
        IShipperDal _shipperDal;

        public ShipperManager(IShipperDal shipperDal)
        {
            _shipperDal = shipperDal;
        }

        [ValidationAspect(typeof(ShipperValidator))]
        public IResult Add(Shipper shipper)
        {
            _shipperDal.Add(shipper);
            return new SuccessResult(Messages.ShipperAdded);
        }

        public IResult Delete(Shipper shipper)
        {
            _shipperDal.Delete(shipper);
            return new SuccessResult(Messages.ShipperDeleted);
        }

        public IDataResult<List<Shipper>> GetAll()
        {
            return new SuccessDataResult<List<Shipper>>(_shipperDal.GetAll());
        }

        public IDataResult<Shipper> GetByShipperId(int shipperId)
        {
            return new SuccessDataResult<Shipper>(_shipperDal.Get(s => s.ShipperId == shipperId));
        }

        public IResult Update(Shipper shipper)
        {
            _shipperDal.Update(shipper);
            return new SuccessResult(Messages.ShipperUpdated);
        }
    }
}
