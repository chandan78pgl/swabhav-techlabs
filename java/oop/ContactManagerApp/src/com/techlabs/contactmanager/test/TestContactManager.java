package com.techlabs.contactmanager.test;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Iterator;

import com.techlabs.contactmanager.Contact;
import com.techlabs.contactmanager.ContactManager;

public class TestContactManager {
	public static void main(String[] args) throws FileNotFoundException, ClassNotFoundException, IOException{

		ContactManager contact = new ContactManager();

		startContactManager(contact);
	}

	private static void startContactManager(ContactManager contact) throws IOException {
		
		boolean isExit = false;
		System.out.println("Contact Manager Started.....");
		
		while(!isExit) {
			System.out.println("\nSelect any option BELOW:"
							+ "\n1. Add new Contact."
							+ "\n2. Display Contact."
							+ "\n3. Quit."
							+ "\n Enter Choice: ");

			int choice = 0;
			final int add=1,display=2,quit=3;

			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
			choice = Integer.parseInt(br.readLine());

			switch (choice) {
			case add:
				add(contact);
				break;
			case display:
				printDetails(contact);
				break;
			case quit:
				System.out.println("The program is now Closed");
				isExit = true;
				break;
			default:
				System.out.println("You have to Select  an option given above");
				break;
			}
		}

	}

	private static void add(ContactManager contact) throws IOException {
		System.out.println("Enter name: ");
		BufferedReader br1 = new BufferedReader(new InputStreamReader(System.in));
		String contactName = br1.readLine();

		System.out.println("Enter Number: ");
		br1 = new BufferedReader(new InputStreamReader(System.in));
		String contactNumber = br1.readLine();

		contact.addContact(contactName, contactNumber);
	}

	private static void printDetails(ContactManager contact) {

		Iterator<Contact> contactIterator = contact.getContacts().iterator();

		System.out
				.println("Displaying Contacts\n-------------------------------");
		while (contactIterator.hasNext()) {
			System.out.println(contactIterator.next());
			System.out.println("-----------------------------------------");
		}
	}
}
