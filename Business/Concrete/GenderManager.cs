using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class GenderManager : IGenderService
    {
        IGenderDal _genderDal;
        public GenderManager(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }

        public IResult Add(Gender gender)
        {
            _genderDal.Add(gender);
            return new SuccessResult();
        }

        public IResult Delete(Gender gender)
        {
            _genderDal.Delete(gender);
            return new SuccessResult();
        }

        public IDataResult<List<Gender>> GetAll()
        {
            return new SuccessDataResult<List<Gender>>(_genderDal.GetAll());
        }

        public IDataResult<Gender> GetById(int genderId)
        {
            return new SuccessDataResult<Gender>(_genderDal.Get(g => g.Id == genderId));
        }

        public IResult Update(Gender gender)
        {
            _genderDal.Update(gender);
            return new SuccessResult();
        }
    }
}
