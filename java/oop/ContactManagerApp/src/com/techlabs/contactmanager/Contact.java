package com.techlabs.contactmanager;

import java.io.Serializable;

public class Contact implements Serializable{
	
	private static final long serialVersionUID = -7545256877249672328L;
	private String name;
	private String number;
	
	public Contact(String name,String number){
		this.name=name;
		this.number=number;
	}
	
	@Override
	public String toString(){
		return "Contact Name: "+this.name
				+"\nContact number: "+this.number;
	}
}
