package com.techlabs.icrudable;

public class VendorDB implements ICRUDable{
	
	public void create(){
		System.out.println("VendorDB is created");
	}
	public void update(){
		System.out.println("VendorDB is updated");
	}
	public void read(){
		System.out.println("VendorDB is Showing");
	}
	public void delete(){
		System.out.println("VendorDB is deleting");
	}
}
