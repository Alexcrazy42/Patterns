namespace Observer.Observers
{
    public class FirstObserver : Interfaces.IObserver<int>
    {
        private Interfaces.IObservable<int> product;
        
        public FirstObserver(Interfaces.IObservable<int> product)
        {
            this.product = product;
            product.AddObserver(this);
        }

        public void Update(int price)
        {
            if (price < 300)
            {
                Console.WriteLine($"First observer bought product by {price}");
                product.RemoveObserver(this);
            }
        }
    }
}
