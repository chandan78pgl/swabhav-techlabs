package com.techlabs.college;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public abstract class Person {
	private int id;
	private String name;
	private String address;
	private Date dob;
	
	public Person(int id, String name,String address,String dob) throws ParseException{
		this.id=id;
		this.name=name;
		this.address=address;
		this.dob=convertToDate(dob);
	}
	
	public int getId() {
		return this.id;
	}
	public String getName() {
		return this.name;
	}
	public String getAddress() {
		return this.address;
	}
	public String getDateOfBirth(){
		SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
		return formatter.format(this.dob);
	}
	
	private Date convertToDate(String dob)throws ParseException{
		SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
		Date date=null;
		date = formatter.parse(dob);
		return date;
	}
}
