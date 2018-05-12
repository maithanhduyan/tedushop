using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class ProductServiceTest
    {
        private Mock<IProductRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IProductService _productService;
        private Mock<IProductTagRepository> _mockProductTagRepository;
        private Mock<ITagRepository> _mockTagRepository;
        private List<Product> _listProduct;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IProductRepository>();
            _mockTagRepository = new Mock<ITagRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockProductTagRepository = new Mock<IProductTagRepository>();
            _productService = new ProductService(_mockRepository.Object, _mockProductTagRepository.Object, _mockTagRepository.Object, _mockUnitOfWork.Object);
        }

        [TestMethod]
        public void Add()
        {
            _productService.Add(new Product() { Name = "", Alias = "", CategoryID = 1 });
        }

        [TestMethod]
        public void GetAll()
        {
            //Setup Method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listProduct);

            //Call Action
            var result = _productService.GetAll() as List<Product>;

            //Compare
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }
    }
}