package com.techlabs.testdatastructures;

public class Customer implements Comparable<Customer> {
	private int id;
	private String name;
	private int numberOfOrders;
	
	public Customer(int id,String name,int numberOfOrders){
		this.id=id;
		this.name=name;
		this.numberOfOrders=numberOfOrders;
	}
	
	public int getId() {
		return this.id;
	}
	public String getName() {
		return this.name;
	}
	public int getNumberOfOrders() {
		return this.numberOfOrders;
	}
	
	@Override
	public int hashCode(){
		return this.name.hashCode();
	}
	
	@Override
	public boolean equals(Object acustomer){
		Customer customer=(Customer)acustomer;
		return getName().equals(customer.getName());
	}
	
	
	public String toString(){
		return "\nID: "+this.id
				+"\nName: "+this.name
				+"\nNumberOfOrders: "+this.numberOfOrders;
	}

	@Override
	public int compareTo(Customer customer) {
		return this.name.compareTo(customer.getName());
	}
}
