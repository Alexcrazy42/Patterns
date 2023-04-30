using Observer.Observable;
using Observer.Observers;

Product product = new Product(400);

FirstObserver firstObserver = new FirstObserver(product);
SecondObserver secondObserver = new SecondObserver(product);

product.ChangePrice(300);
product.ChangePrice(270);
