using Observer.Interfaces;

namespace Observer.Observable
{


    public class Product : Interfaces.IObservable<int>
    {
        private List<Interfaces.IObserver<int>> observers;
        private int price;

        public Product(int p)
        {
            price = p;
            observers = new List<Interfaces.IObserver<int>>();
        }

        public void ChangePrice(int p)
        {
            price = p;
            Notify();
        }


        public void AddObserver(Interfaces.IObserver<int> observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Interfaces.IObserver<int> observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers.ToList())
            {
                observer.Update(price);
            }
        }

        
    }
}
