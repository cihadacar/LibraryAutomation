using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntitiyRepositoryBase<Customer, LibraryAutomationContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDto()
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())
            {
                var result = from c in context.Customers
                             join a in context.Addresses
                             on c.AddressId equals a.Id
                             join g in context.Genders
                             on c.GenderId equals g.Id
                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 Address = (from ct in context.Cities
                                            where ct.Id == a.CityId
                                            from ds in context.Districts
                                            where ds.Id == a.DistrictId
                                            select new AddressDetailDto
                                            {
                                                Id = a.Id,
                                                AddressDetail = a.AddressDetail,
                                                City = new City { Id = ct.Id, CityName = ct.CityName},
                                                District = new District { Id = ds.Id, DistrictName = ds.DistrictName, CityId = ds.CityId}
                                            }).FirstOrDefault(),
                                 Gender = new Gender { Id = g.Id, GenderName = g.GenderName },
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 DateOfBirth = c.DateOfBirth,
                                 NationalId = c.NationalId,
                                 PhoneNumber = c.PhoneNumber
                             };
                return result.ToList();
            }
        }
    }
}
