using System.Text;

public class Order{
    public Order(Customer customer)
    {
        _customer = customer;
    }
    private Customer _customer;
    private List<Product> _products = [];
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string DisplayOrder(string orderName)
    {
        double shipping = CalculateShipping();
        double cost = CalculateTotalCostOfProducts();
        StringBuilder order = new StringBuilder();
        order.AppendLine(orderName);
        order.AppendLine($"{_customer.GetCustomerName()}");
        order.AppendLine($"{CreatePackingLabel()}");
        order.AppendLine("Ship To:");
        order.AppendLine($"{CreateShippingLabel()}");
        order.AppendLine($"Shipping: ${shipping:F2}");
        order.AppendLine($"Cost: ${cost:F2}");
        order.AppendLine($"Total Cost: ${cost + shipping:F2}");
        return order.ToString();
    }
    private double CalculateShipping()
    {
        double shipping = 0;
        if (_customer.IsInUSA())
        {
            shipping += 5;
        }
        else
        {
            shipping += 35;
        }
        return shipping;
    }
    private double CalculateTotalCostOfProducts()
    {
        double totalCost = 0;
        
        foreach(Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost;
    }

    private string CreatePackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach(var product in _products)
        {
            packingLabel.AppendLine(product.DisplayProduct()); 
        }
        return packingLabel.ToString();
    }
    private string CreateShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();
        shippingLabel.AppendLine(_customer.GetCustomerName());
        shippingLabel.AppendLine(_customer.GetCustomerAddress().DisplayAddress());
        return shippingLabel.ToString();
    }
}