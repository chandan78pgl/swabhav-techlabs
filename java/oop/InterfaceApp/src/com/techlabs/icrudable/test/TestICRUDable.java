package com.techlabs.icrudable.test;

import com.techlabs.icrudable.CustomerDB;
import com.techlabs.icrudable.ICRUDable;
import com.techlabs.icrudable.InvoiceDB;
import com.techlabs.icrudable.VendorDB;

public class TestICRUDable {
	public static void main(String[] args) {
		ICRUDable icrudAble;
		
		icrudAble=new CustomerDB();
		toDoCreate(icrudAble);
		toDoUpdate(icrudAble);
		toDoRead(icrudAble);
		toDoDelete(icrudAble);
		
		icrudAble=new VendorDB();
		toDoCreate(icrudAble);
		toDoUpdate(icrudAble);
		toDoRead(icrudAble);
		toDoDelete(icrudAble);
		
		icrudAble=new InvoiceDB();
		toDoCreate(icrudAble);
		toDoUpdate(icrudAble);
		toDoRead(icrudAble);
		toDoDelete(icrudAble);
		
	}
	
	public static void toDoCreate(ICRUDable icrudAble){
		icrudAble.create();
	}
	
	public static void toDoUpdate(ICRUDable icrudAble){
		icrudAble.update();
	}
	
	public static void toDoRead(ICRUDable icrudAble){
		icrudAble.read();
	}
	
	public static void toDoDelete(ICRUDable icrudAble){
		icrudAble.delete();
	}
}
