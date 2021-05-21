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
    public class ProductServiceDL : IProductService
    {
        private IUnitOfWork _unitOfWork;
        public ProductServiceDL()
        {
            _unitOfWork = new EFUnitOfWork();
            //InitialiseData();
        }

        public IEnumerable<ProductView> GetAllProducts()
        {
            return _unitOfWork.ProductRepository.GetAll().Select(obj => ProductMapper.ToViewEntity(obj));
        }

        public IEnumerable<ProductView> GetAllProductsInStore(int storeID)
        {
            return _unitOfWork.ProductRepository.GetAll()
                .Where(product => product.StoreId == storeID)
                .Select(obj => ProductMapper.ToViewEntity(obj));
        }

        public IEnumerable<ProductView> GetAllProductsWithSelectedProductType(int productTypeID)
        {
            return _unitOfWork.ProductRepository.GetAll()
                .Where(product => product.ProductTypeId == productTypeID)
                .Select(obj => ProductMapper.ToViewEntity(obj));
        }

        public ProductView GetProductByID(int productID)
        {
            return ProductMapper.ToViewEntity(_unitOfWork.ProductRepository.GetById(productID));        }

        public IEnumerable<ProductView> GetAllProductsWithSelectedProductTypeAndStore(int productTypeID, int storeId)
        {
            return _unitOfWork.ProductRepository.GetAll()
                .Where(product => product.ProductTypeId == productTypeID && product.StoreId == storeId)
                .Select(obj => ProductMapper.ToViewEntity(obj));
        }

        private void InitialiseData()
        {
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 1, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 2, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 5, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 5, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 5, StoreId = 3, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 3, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 5, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 5, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 5, StoreId = 4, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 2, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 4, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.ProductRepository.Create(new Product() { Price = 15, ProductTypeId = 1, StoreId = 5, DateOfProducing = new DateTime()});
            _unitOfWork.Save();
        }

    }
}
