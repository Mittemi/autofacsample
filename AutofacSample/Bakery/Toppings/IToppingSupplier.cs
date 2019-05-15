namespace AutofacSample.Bakery.Toppings
{
    public interface IToppingSupplier<out T> where T: Topping
    {
        T GetTopping();
    }
}