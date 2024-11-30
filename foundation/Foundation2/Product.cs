public class Product
{
    public Product(
        string name,
        int productId,
        double price, 
        int quantity
    )
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public double GetTotalCost(){
        return _price * _quantity;
    }    
    public string DisplayProduct()
    {
        return $"{_productId}: {_name} ${_price:F2}, qty: {_quantity}";
    }
}