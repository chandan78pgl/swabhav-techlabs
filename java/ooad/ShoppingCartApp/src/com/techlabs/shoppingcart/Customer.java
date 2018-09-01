package com.techlabs.shoppingcart;

import java.util.ArrayList;

public class Customer {
	private String name;
	private ArrayList<Order> orders=new ArrayList<Order>();
	
	public Customer(String name){
		this.name=name;
	}
	
	public void addOrders(Order order){
		this.orders.add(order);
	}
	
	public String getCustomerName(){
		return this.name;
	}
	
	public Double getTotalCost(){
		Double orderCost=0.0;
		for(Order order:this.orders){
			orderCost+=order.getOrderCost();
		}
		return orderCost;
	}
	
	public ArrayList<Order> showOrders(){
		return this.orders;
	}
	
	@Override
	public String toString() {
		return "Customer Name: "+this.name
				+"\nCustomer Orders:- \n"+this.orders
				+"\n\nTotal Cost:- "+this.getTotalCost();
	}
}
