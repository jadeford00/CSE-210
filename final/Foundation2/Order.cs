public class Order
{
    private List<Product> products;
    private Customer customer;
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetPrice();
        }
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }

    // public string GetPackingLabel()
    // {
    //     string label = "Packing Label:\n";
    //     foreach (Product product in products)
    //     {
    //         label += $"{product}\n";
    //     }
    //         return label;
    // }


    public string GetPackingLabel()
    {
        return $"ProductLalbel:\n{products}";
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer}";
    }
}