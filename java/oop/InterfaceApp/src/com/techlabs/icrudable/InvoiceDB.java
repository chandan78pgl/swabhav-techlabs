package com.techlabs.icrudable;

public class InvoiceDB implements ICRUDable{
	public void create(){
		System.out.println("InvoiceDB is created");
	}
	public void update(){
		System.out.println("InvoiceDB is updated");
	}
	public void read(){
		System.out.println("InvoiceDB is Showing");
	}
	public void delete(){
		System.out.println("InvoiceDB is deleting");
	}
}
