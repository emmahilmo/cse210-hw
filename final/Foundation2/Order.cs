using System;
public class Order {
    Customer GetCustomer;
    Product GetProduct;
    private List<Product> _products = new List<Product>();
    public Order(List<Product> products) {
        _products = products;
        foreach(Product product in _products) {
            
        }
    }
    public void calculateTotalCost() {
        
    }
    public string GetPackingLabel() {
        return $"{GetProduct}";
    }
    public string GetShippingLabel() {
        return $"{GetCustomer}";
    }
    public void Display() {
        
    }
}