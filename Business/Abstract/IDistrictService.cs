using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IResult Add(District district);
        IResult Delete(District district);
        IResult Update(District district);
        IDataResult<List<District>> GetAll();
        IDataResult<District> GetById(int districtId);
    }
}
