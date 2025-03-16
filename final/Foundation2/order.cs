class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }
        double shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        List<string> labels = new List<string>();
        foreach (var product in products)
        {
            labels.Add(product.GetPackingLabel());
        }
        return string.Join("\n", labels);
    }

    public string GetShippingLabel()
    {
        return customer.GetShippingLabel();
    }
}
