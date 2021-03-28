using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);  //önceden void olan yerler artık IResult: çünkü işlemin başarılı olup olmadığını return ediyoruz. 
        IResult Delete(Car car);
        IResult Update(Car car);

        IResult AddTransactionalTest(Car car);

    }
}
