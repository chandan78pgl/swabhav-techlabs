package com.techlabs.shoppingcart;

import java.util.ArrayList;
import java.util.Date;
import java.util.Iterator;

public class Order {
	private ArrayList<LineItem> items=new ArrayList<LineItem>();
	private Double cost=0.0;
	private Date date;
	
	public Double getOrderCost(){
		double cost=0;
		for(LineItem lineItems: this.items){
			cost+=lineItems.calculateItemCost();
		}
		this.cost=cost;
		return cost;
	}
	
	
	public void addToCart(LineItem item){
		for(LineItem lineItems: this.items){
			if(lineItems.getProduct().getProductName().equalsIgnoreCase(item.getProduct().getProductName())){
				lineItems.addQuantity(item.getQuantity());
				System.out.println("Quantity Added");
				return;
			}
		}
		items.add(item);
	}
	
	@Override
	public String toString() {
	
		return "\n----------------------------------Orders: \n"
				+this.items
				+" OrderCost:- "+this.getOrderCost();
	}
}
