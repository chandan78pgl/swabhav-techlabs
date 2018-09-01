package com.techlabs.shoppingcart.test;

import java.io.IOException;

import com.techlabs.shoppingcart.Customer;
import com.techlabs.shoppingcart.ExportToHtml;
import com.techlabs.shoppingcart.LineItem;
import com.techlabs.shoppingcart.Order;
import com.techlabs.shoppingcart.Product;

public class TestShoppingCart {

	public static void main(String[] args) throws IOException {
		
		Customer customer1=new Customer("Chandan");
		startShopping(customer1);
		ExportToHtml.exportToHtmlFile(customer1.toString());
		startShopping(customer1);
		
		Customer customer2=new Customer("Dharmesh");
		startShopping2(customer2);
		ExportToHtml.exportToHtmlFile(customer2.toString());
	}
	
	public static void startShopping(Customer customer){
		Product product1=new Product(100, "Shoes", 2000, 199);
		Product product2=new Product(101, "Shirt", 3000, 1999);
		
		LineItem lineItem1=new LineItem(product1,10);
		LineItem lineItem2=new LineItem(product2,5);
		
		Order order1=new Order();
		order1.addToCart(lineItem1);
		order1.addToCart(lineItem2);
		
		customer.addOrders(order1);
		System.out.println(customer);
		System.out.println("End Of Shopping");
	}
	public static void startShopping2(Customer customer){
		Product product1=new Product(100, "Book", 20, 2);
		Product product2=new Product(101, "Pen", 100, 19);
		
		LineItem lineItem1=new LineItem(product1,10);
		LineItem lineItem2=new LineItem(product2,5);
		
		Order order1=new Order();
		order1.addToCart(lineItem1);
		order1.addToCart(lineItem2);
		
		customer.addOrders(order1);
		System.out.println(customer);
		System.out.println("End Of Shopping");
	}
}
