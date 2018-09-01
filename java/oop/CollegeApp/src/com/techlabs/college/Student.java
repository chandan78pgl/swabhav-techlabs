package com.techlabs.college;

import java.text.ParseException;

public class Student extends Person {

	private Branch branch;
	private int semester;
	
	public Student(int id,String name,String address,String dob,Branch branch,int semester) throws ParseException{
		super(id, name, address, dob);
		this.branch=branch;
		this.semester=semester;
	}
	
	public String getBranch(){
		return this.branch.name();
	}
	
	public int getSemester(){
		return this.semester;
	}
}
