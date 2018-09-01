package com.techlabs.shoppingcart.test;

import com.techlabs.shoppingcart.Product;

public class TestProduct {
	public static void main(String[] args) {
		Product product1=new Product(100, "Pen", 25, 2);
		Product product2=new Product(102, "Book",50, 5);
		
		System.out.println(product1.calculateCostToDiscount());
		System.out.println(product2.calculateCostToDiscount());
	}
}
