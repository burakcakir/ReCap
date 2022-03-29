using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (!rental.ReturnDate.Equals(null))
            {
                _rentalDal.Add(rental);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new Result(true);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r=>r.Id == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);

            return new Result(true);
        }
    }
}
