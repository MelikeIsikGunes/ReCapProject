using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            //Kurallar
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            //Kurallar
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(), Messages.ColorsListed);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == id), Messages.ColorGetById);
        }

        public IResult Update(Color color)
        {
            //Kurallar
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
