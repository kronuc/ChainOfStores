using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    public class ProductTypeServiceWithoutDB : IProductTypeService
    {
        private List<ProductTypeView> _productTypes;

        public ProductTypeServiceWithoutDB()
        {
            _productTypes = new List<ProductTypeView>();
            InitialiseData();
        }


        public IEnumerable<ProductTypeView> GetAllProductTypes()
        {
            return _productTypes.ToList();
        }


        public ProductTypeView GetProductTypeByID(int productTypeId)
        {
            return _productTypes.Where(type => type.Id == productTypeId).FirstOrDefault();
        }
        public IEnumerable<ProductTypeView> FindByName(string name)
        {
            return _productTypes.Where(type => type.Name.Contains(name ?? ""));
        }

        private void InitialiseData()
        {
            _productTypes.Add(new ProductTypeView() { Id = 1, Name = "product type 1", PriceRecomendation = 15.23f, ExpirationDate = 14 });
            _productTypes.Add(new ProductTypeView() { Id = 2, Name = "product type 2", PriceRecomendation = 16.0f, ExpirationDate = 140 });
            _productTypes.Add(new ProductTypeView() { Id = 3, Name = "product type 3", PriceRecomendation = 900.2f, ExpirationDate = 2 });
            _productTypes.Add(new ProductTypeView() { Id = 4, Name = "product type 4", PriceRecomendation = 120.6f, ExpirationDate = 10 });
            _productTypes.Add(new ProductTypeView() { Id = 5, Name = "product type 5", PriceRecomendation = 0.23f, ExpirationDate = 1000 });
        }

        
    }
}
