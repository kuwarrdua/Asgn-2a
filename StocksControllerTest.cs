using CarStockingg.Controllers;
using CarStockingg.Data;
using CarStockingg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarStockingTest
{
    [TestClass]
    public class StocksControllerTest
    {
        StocksController stocksController;

        List<Stock> stocks;

        private ApplicationDbContext _context;

        [TestInitialize]
        public void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);
            stocks = new List<Stock>();

            Supplier mockSupplier = new Supplier
            {
                SupplierId = 5555,
                Name = "A Fake Supplier"
            };

            stocks.Add(new Stock
            {
                StockId = 100,
                CarMake = "Some Company",
                Location = "Barrie",
                Price = 665,
                Supplier = mockSupplier
            });

            stocks.Add(new Stock
            {
                StockId = 200,
                CarMake = "Some Company",
                Location = "Toronto",
                Price = 999,
                Supplier = mockSupplier
            });

            stocks.Add(new Stock
            {
                StockId = 300,
                CarMake = "Some Company",
                Location = "Hamilton",
                Price = 981,
                Supplier = mockSupplier
            });

            foreach (var k in stocks)
            {
                // add each product to in-memory db
                _context.Stocks.Add(k);
            }
            _context.SaveChanges();

            stocksController = new StocksController(_context);
        }

        [TestMethod]
        public void IndexLoadsCorrectView()
        {
            // act
            var result = stocksController.Index().Result;
            var viewResult = (ViewResult)result;

            // ASSERT
            Assert.AreEqual("Index", viewResult.ViewName);
        }

        [TestMethod]
        public void IndexReturnsProducts()
        {
            // act
            var result = stocksController.Index().Result;

            // get the view result
            var viewResult = (ViewResult)result;

            // assert - convert result to list of products & compare to mock product list
            CollectionAssert.AreEqual(stocks.OrderBy(p => p.CarMake).ToList(), (List<Stock>)viewResult.Model);
        }

        [TestMethod]
        public void DetailsMissingId()
        {
            // act
            var result = stocksController.Details(null).Result;

            // assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void DetailsInvalidId()
        {
            // act
            var result = stocksController.Details(8879).Result;

            // assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void DetailsValidIdLoadsProduct()
        {
            // act
            var result = stocksController.Details(200).Result;
            var viewResult = (ViewResult)result;

            // assert
            Assert.AreEqual(stocks[1], viewResult.Model);
        }


    }
}
