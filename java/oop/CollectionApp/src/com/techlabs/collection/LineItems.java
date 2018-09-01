package com.techlabs.collection;

public class LineItems {

	private int id;
	private String name;
	private int quantity;
	private double price;
	
	public LineItems(int id,String name,int quantity,double price){
		this.id=id;
		this.name=name;
		this.quantity=quantity;
		this.price=price;
	}
	
	public double totalCost(){
		return this.price*this.quantity;
	}
}
