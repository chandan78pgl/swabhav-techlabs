package com.techlabs.shoppingcart.test;

import com.techlabs.shoppingcart.LineItem;
import com.techlabs.shoppingcart.Order;
import com.techlabs.shoppingcart.Product;

public class TestOrder {
	public static void main(String[] args) {
		Order order1=new Order();
		LineItem lineItem1=new LineItem(new Product(101, "pen", 25, 3), 5);
		LineItem lineItem2=new LineItem(new Product(102, "Book", 50, 5), 10);
		order1.addToCart(lineItem1);
		order1.addToCart(lineItem2);
		
		System.out.println(order1.getOrderCost());
	}
}
