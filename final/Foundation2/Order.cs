using System;
public class Order {
    Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer, List<Product> products) {
        _products = products;
        _customer = customer;
    }
    public float computeTotalPrice() {
        float sum = 0;
        for (int i = 0; i < _products.Count; i++){
            sum += _products[i].computePrice();
        }
        if(_customer.isUSACustomer()) {
            sum += 5;
        }
        else {
            sum += 35;
        }
        return sum;
    }
    public string GetPackingLabel() {
        string label = "";
        for(int i = 0; i < _products.Count; i++) {
            label += _products[i].GetName() + ", " + _products[i].GetId() + "\n";
        }
        return label;
    }
    public string GetShippingLabel() {
        return $"{_customer.GetName()} {_customer.GetAddress()}";
    }
}