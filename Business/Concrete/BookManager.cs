using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class BookManager : IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult();
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult();
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IDataResult<Book> GetById(int bookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b => b.Id == bookId));
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult();
        }
    }
}
