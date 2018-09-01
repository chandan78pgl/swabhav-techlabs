package com.techlabs.contactmanager;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;

public class ContactManager{

	private ArrayList<Contact> contacts;
	
	public ContactManager() throws FileNotFoundException, ClassNotFoundException, IOException{
		this.contacts=StoreContact.getObjectFromFile();
	}
	
	public void addContact(String name,String number) throws FileNotFoundException, IOException{
		this.contacts.add(new Contact(name,number));
		StoreContact.saveObjectToFile(this.contacts);
	}
	
	public ArrayList<Contact> getContacts(){
		return this.contacts;
	}
	
}
