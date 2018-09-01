package com.techlabs.shoppingcart;

public class LineItem {
	private Product product;
	private int quantity;
	
	public LineItem(Product product,int quantity){
		this.product=product;
		this.quantity=quantity;
	}

	public Product getProduct(){
		return this.product;
	}
	
	public void addQuantity(int quantity){
		this.quantity+=quantity;
	}
	
	public int getQuantity(){
		return this.quantity;
	}
	
	public Double calculateItemCost(){
		return this.product.calculateCostToDiscount()*this.quantity;
	}
	
	@Override
	public String toString() {
	
		return "\nLineItems: \n"
				+this.product
				+" Quantity:- "+this.quantity
				+" ItemCost:- "+this.calculateItemCost()
				+"\n------------------------\n";
	}
}
