package com.techlabs.customer;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Customer {
	
	public static int tempId;
	private int id;
	private String firstname;
	private String lastname;
	private Date dateOfBirth;
	
	static{
		tempId=100;
	}
	
	public Customer(String firstname,String lastname,String dob)throws ParseException{
		tempId++;
		this.id=tempId;
		this.firstname=firstname;
		this.lastname=lastname;
		this.dateOfBirth=convertToDate(dob);
	}
	
	public int getId(){
		return this.id;
	}
	
	public String getFirstname(){
		return this.firstname;
	}
	
	public String getLastname(){
		return this.lastname;
	}
	
	public String getDateOfBirth(){
		SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
		return formatter.format(dateOfBirth);
	}
	
	private Date convertToDate(String dob)throws ParseException{
		SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
		Date date=null;
		date = formatter.parse(dob);
		return date;
	}
	
	public int calculateAge(){
		Date date=new Date();
		SimpleDateFormat formatter=new SimpleDateFormat("yyyy");
		int curr_year = Integer.parseInt(formatter.format(date));
		int dob_year=Integer.parseInt(formatter.format(this.dateOfBirth));
		
		return curr_year-dob_year;
	}
}
