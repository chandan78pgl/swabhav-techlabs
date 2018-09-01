package com.techlabs.shoppingcart.test;

import com.techlabs.shoppingcart.Customer;
import com.techlabs.shoppingcart.LineItem;
import com.techlabs.shoppingcart.Order;
import com.techlabs.shoppingcart.Product;

public class TestCustomer {
	public static void main(String[] args) {
		Customer customer=new Customer("Chandan");
		Order order1=new Order();
		LineItem lineItem1=new LineItem(new Product(101, "pen", 25, 3), 5);
		LineItem lineItem2=new LineItem(new Product(102, "Book", 50, 5), 10);
		order1.addToCart(lineItem1);
		order1.addToCart(lineItem2);
		
		
		Order order2=new Order();
		LineItem lineItem11=new LineItem(new Product(101, "pen", 25, 3), 5);
		LineItem lineItem21=new LineItem(new Product(102, "Book", 50, 5), 10);
		order2.addToCart(lineItem11);
		order2.addToCart(lineItem21);
		
		customer.addOrders(order1);
		customer.addOrders(order2);
		System.out.println(customer);
	}
}
