package com.techlabs.shoppingcart;

public class Product {
	private int id;
	private String name;
	private double cost;
	private double discount;
	
	public Product(int id,String name,double cost,double discount){
		this.id=id;
		this.name=name;
		this.cost=cost;
		this.discount=discount;
	}
	
	public int getProductId(){
		return this.id;
	}
	
	public String getProductName(){
		return this.name;
	}
	
	public Double getProductCost(){
		return this.cost;
	}
	
	public Double getProductDiscount(){
		return this.discount;
	}
	
	public Double calculateCostToDiscount(){
		return this.cost-this.discount;
	}
	
	@Override
	public String toString() {
		
		return "Product Details: \n"
				+"\nProduct Id:- "+this.id
				+" Name:- "+this.name
				+" Cost:- "+this.cost
				+" Discount:- "+this.discount
				+"\n CostToDiscount:- "+this.calculateCostToDiscount();
	}
}
