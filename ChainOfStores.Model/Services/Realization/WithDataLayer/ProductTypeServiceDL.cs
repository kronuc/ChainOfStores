using ChainOfStores.EFData.Entities;
using ChainOfStores.EFData.UnitOfWork.Interfaces;
using ChainOfStores.EFData.UnitOfWork.Realisation.EFRealisation;
using ChainOfStores.Model.Mappers;
using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WithDataLayer
{
    public class ProductTypeServiceDL : IProductTypeService
    {
        private IUnitOfWork _unitOfWork;
        public ProductTypeServiceDL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //InitialiseData();
        }


        public IEnumerable<ProductTypeView> GetAllProductTypes()
        {
            return _unitOfWork.ProductTypeRepository
                .GetAll()
                .Select(obj => ProductTypeMapper.ToViewEntity(obj));
        }


        public ProductTypeView GetProductTypeByID(int productTypeId)
        {
            return ProductTypeMapper.ToViewEntity(_unitOfWork.ProductTypeRepository.GetById(productTypeId));
        }
        public IEnumerable<ProductTypeView> FindByName(string name)
        {
            return _unitOfWork.ProductTypeRepository
                .GetAll()
                .Where(type => type.Name.Contains(name))
                .Select(obj => ProductTypeMapper.ToViewEntity(obj));
        }

        private void InitialiseData()
        {
            _unitOfWork.ProductTypeRepository.Create(new ProductType() { Name = "product type 1", PriceRecomendation = 15.23f, ExpirationDate = 14 });
            _unitOfWork.ProductTypeRepository.Create(new ProductType() { Name = "product type 2", PriceRecomendation = 16.0f, ExpirationDate = 140 });
            _unitOfWork.ProductTypeRepository.Create(new ProductType() { Name = "product type 3", PriceRecomendation = 900.2f, ExpirationDate = 2 });
            _unitOfWork.ProductTypeRepository.Create(new ProductType() { Name = "product type 4", PriceRecomendation = 120.6f, ExpirationDate = 10 });
            _unitOfWork.ProductTypeRepository.Create(new ProductType() { Name = "product type 5", PriceRecomendation = 0.23f, ExpirationDate = 1000 });
            _unitOfWork.Save();
        }

        
    }
}
