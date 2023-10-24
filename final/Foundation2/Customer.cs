using System;
public class Customer {
    private string _customerName;
    Address _address;
    public Customer(string name, Address address) {
        _customerName = name;
        _address = address;
    }
    public void isUSACustomer() {
        if(_address.isInUSA() == true) {
            
        }
        else {

        }
    }
}