package com.techlabs.customer.test;

import java.text.ParseException;

import com.techlabs.customer.Customer;

public class TestCustomer {
	public static void main(String[] args)throws ParseException{
		Customer customer1=new Customer("Chandan", "Maharana", "25/11/1995");
		Customer customer2=new Customer("Dharmesh", "Nayak", "22/12/1995");
		Customer customer3=new Customer("Brijesh","Patel","23/02/1996");
		
		printDetails(customer1);
		printDetails(customer2);
		printDetails(customer3);
	}
	
	private static void printDetails(Customer customer){
		System.out.println("Customer id: "+customer.getId()
				+"\nFirstname: "+customer.getFirstname()
				+"\nLastname: "+customer.getLastname()
				+"\nDate Of Birth: "+customer.getDateOfBirth()
				+"\nAge: "+customer.calculateAge());
		System.out.println("--------------------------------------");
	}
}
