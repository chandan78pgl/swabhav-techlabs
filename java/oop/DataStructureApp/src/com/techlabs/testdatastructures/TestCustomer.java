package com.techlabs.testdatastructures;

import java.util.HashSet;
import java.util.TreeSet;

public class TestCustomer {
	public static void main(String[] args) {
		
		implementHashSet();
		implementTreeSet();
	}

	private static void implementHashSet() {
		HashSet<Customer> customerset=new HashSet<Customer>();
	
		Customer customer1=new Customer(101, "Chandan", 12);
		Customer customer2=new Customer(101, "Chandan", 12);
		Customer customer3=new Customer(101, "Chandan", 12);
		
		customerset.add(customer1);
		customerset.add(customer2);
		customerset.add(customer3);
		
		System.out.println("HashSet");
		System.out.println(customerset);
	}
	
	private static void implementTreeSet(){
		TreeSet<Customer> customerset=new TreeSet<Customer>();
		
		Customer customer1=new Customer(101, "Chandan", 12);
		Customer customer2=new Customer(101, "Chandan", 12);
		Customer customer3=new Customer(101, "Chandan", 12);
		
		customerset.add(customer1);
		customerset.add(customer2);
		customerset.add(customer3);
		
		System.out.println("TreeSet");
		System.out.println(customerset);
	}
}
