using System;
public class Customer {
    private string _name;
    private int _shipping;
    Address GetAddress;
    public Customer(string name) {
        _name = name;
    }
    public void isUSACustomer() {
        if(GetAddress.isInUSA() == true) {
            _shipping = 5;
        }
        else {
            _shipping = 35;
        }
    }
    public string GetCustomer() {
        return $"{_name} {GetAddress}";
    }
}