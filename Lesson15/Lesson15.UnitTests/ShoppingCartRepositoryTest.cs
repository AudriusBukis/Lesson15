using Lesson15.Modules;
using Xunit;

namespace Lesson15.UnitTests
{
    public class ShoppingCartRepositoryTest
    {
        [Fact]
        public void Test_If_Function_Correct_calculate_Total_Sum()
        {
            ShoppingCartRepository cart = new();
            cart.ShoppCart.Add(new ShoppingCart("Snikers", 15693035, "85 g", 1.5));
            cart.ShoppCart.Add(new ShoppingCart("Mars", 15452035, "50 g", 2.5));
            cart.ShoppCart.Add(new ShoppingCart("Twix", 16481335, "85 g", 1.5));
            cart.ShoppCart.Add(new ShoppingCart("Snikers", 15846635, "60 g", 1.3));
            cart.ShoppCart.Add(new ShoppingCart("Mars", 45846335, "100 g", 8.5));
            double total = 0;

            total = ShoppingCartRepository.GenerateCheck(cart.ShoppCart);

            Assert.Equal(15.3, total);
           
        }
    }
}
