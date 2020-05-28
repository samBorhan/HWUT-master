using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange
              
            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Description_Set_Value_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();


            // Act
            result.Description = "Sam";

            // Assert
            Assert.AreEqual("Sam", result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Set_Value_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "Sam";

            // Assert
            Assert.AreEqual("Sam",result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Id_Set_Value_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "123";

            // Assert
            Assert.AreEqual("123", result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Set_Value_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "Sam Borhan";

            // Assert
            Assert.AreEqual("Sam Borhan", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Set_Value_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "Sam Picture";

            // Assert
            Assert.AreEqual("Sam Picture", result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Set_Value_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "Sam.SeattleU.com";

            // Assert
            Assert.AreEqual("Sam.SeattleU.com", result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Set_Value_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "Sam title";

            // Assert
            Assert.AreEqual("Sam title", result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ProductModel_toString_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.ToString();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_AverageRatingg_With_Null_Ratings_Zero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();


            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(0,result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatingg_With_Zero_Total_Ratings_Zero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();


            // Act
            for (int i = 0; i < result.Ratings.Length; i++ ) 
            {

                result.Ratings[i] = 0;

            }

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatingg_With_Zero_Item_Zero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();


            // Act
            
                result.Ratings = new int[0];

           
            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }
    }
}


