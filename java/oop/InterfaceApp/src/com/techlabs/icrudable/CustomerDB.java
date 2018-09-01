package com.techlabs.icrudable;

public class CustomerDB implements ICRUDable {
	public void create(){
		System.out.println("CustomerDB is created");
	}
	public void update(){
		System.out.println("CustomerDB is updated");
	}
	public void read(){
		System.out.println("CustomerDB is Showing");
	}
	public void delete(){
		System.out.println("CustomerDB is deleting");
	}
}
