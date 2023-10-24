using System;
public class Order {
    Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer, List<Product> products) {
        _customer = customer;
        _products = products;
    }
    public void calculateTotalCost() {

    }
    public string GetPackingLabel() {
        return $"";
    }
    public string GetShippingLabel() {
        return $"";
    }
}