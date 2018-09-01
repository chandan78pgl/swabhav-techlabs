package com.techlabs.shoppingcart.test;

import com.techlabs.shoppingcart.LineItem;
import com.techlabs.shoppingcart.Product;

public class TestLineItem {
	public static void main(String[] args) {
		LineItem lineItem1=new LineItem(new Product(101, "pen", 25, 3), 5);
		LineItem lineItem2=new LineItem(new Product(102, "Book", 50, 5), 10);
		
		System.out.println(lineItem1.calculateItemCost());
		System.out.println(lineItem2.calculateItemCost());
	}
}
