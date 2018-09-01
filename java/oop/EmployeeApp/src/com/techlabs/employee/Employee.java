package com.techlabs.employee;

public abstract class Employee {
	private int empId;
	private String name;
	protected double basicSalary,HRA=0,TA=0,DA=0;
	
	public Employee(String name,double salary){
		this.empId=(int)(Math.random()*100)+100;
		this.name=name;
		this.basicSalary=salary;
	}
	
	public int getEmployeeId(){
		return this.empId;
	}
	
	public String getName(){
		return this.name;
	}
	
	abstract public String getAllowance();
	abstract public double getSalary();
}
