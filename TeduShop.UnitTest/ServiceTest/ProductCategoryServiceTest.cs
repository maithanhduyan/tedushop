using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class ProductCategoryServiceTest
    {
        private Mock<IProductCategoryRepository> _mockProductCategoryRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IProductCategoryService _productCategoryService;
        private List<ProductCategory> _listProductCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockProductCategoryRepository = new Mock<IProductCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _productCategoryService = new ProductCategoryService(_mockProductCategoryRepository.Object, _mockUnitOfWork.Object);
            _listProductCategory = new List<ProductCategory>() {
            new ProductCategory() {Name="Clothing", Alias="Clothing" }
            };
        }

        [TestMethod]
        public void Create()
        {
            ProductCategory _productCategory = new ProductCategory();
            _productCategory.Name = "Đồ uống";
            _productCategory.Alias = "Đồ uống";
            _productCategory.CreatedDate = DateTime.Now;
            _mockProductCategoryRepository.Setup(m => m.Add(_productCategory)).Returns((ProductCategory p) =>
            {
                p.ID = 1;
                return p;
            });
            var result = _productCategoryService.Add(_productCategory);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}