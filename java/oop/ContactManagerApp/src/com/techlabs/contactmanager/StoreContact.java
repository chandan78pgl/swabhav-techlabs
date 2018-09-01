package com.techlabs.contactmanager;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

public abstract class StoreContact {
	public static void saveObjectToFile(ArrayList<Contact> contacts) throws FileNotFoundException, IOException{
		
		ObjectOutputStream oo=new ObjectOutputStream(new FileOutputStream("resource/contact.ser"));
		oo.writeObject(contacts);
		oo.close();
	}
	
	@SuppressWarnings("unchecked")
	public static ArrayList<Contact> getObjectFromFile() throws ClassNotFoundException{
		ObjectInputStream oi;
		ArrayList<Contact> contacts =new ArrayList<Contact>();
		try {
			oi = new ObjectInputStream(new FileInputStream("resource/contact.ser"));
			contacts=(ArrayList<Contact>) oi.readObject();
			oi.close();
		} catch (FileNotFoundException f){
			return contacts;
		} catch (IOException e){
			e.printStackTrace();
		}
		
		return contacts;
	}
}
