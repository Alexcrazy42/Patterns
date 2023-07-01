

namespace Observer.Observers
{
    public class SecondObserver : Interfaces.IObserver<int>
    {
        private Interfaces.IObservable<int> product;

        public SecondObserver(Interfaces.IObservable<int> product)
        {
            this.product = product;
            product.AddObserver(this);
        }

        public void Update(int price)
        {
            if (price < 350)
            {
                Console.WriteLine($"Second observer bought product by {price}");
                product.RemoveObserver(this);
            }
        }
    }
}
