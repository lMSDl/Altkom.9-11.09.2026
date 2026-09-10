namespace DesignPatterns.Structural.Facade.II
{
    internal class Client
    {
        static IBasketService _basketService;
        static IProductsService _productsService;
        static IPaymentService _paymentService;

        public static void Execute()
        {
            int[] products = [2, 55, 34, 773, 251];

            /*foreach (var productId in products)
            {
                float price = _productsService.GetPrice(productId);
                _basketService.AddProduct(productId, price);
            }
            var totalPrice = _basketService.GetTotalPrice();
            _paymentService.Pay(_basketService.GetId(), totalPrice);*/

            Shop shop = new Shop(_basketService, _productsService, _paymentService);
            shop.Buy(products);
        }
    }
}
