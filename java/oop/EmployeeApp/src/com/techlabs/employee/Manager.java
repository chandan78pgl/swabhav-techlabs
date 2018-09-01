package com.techlabs.employee;

public class Manager extends Employee {
	private double salary=this.basicSalary;
	
	public Manager(String name,double salary){
		super(name,salary);
		this.HRA=0.3;
		this.TA=0.4;
		this.DA=0.5;
	}

	@Override
	public String getAllowance(){
		return "\nHRA: "+this.HRA*salary
				+"\nTA: "+this.TA*salary
				+"\nDA: "+this.DA*salary;
	}
	
	@Override
	public double getSalary() {
		
		double ctcSalary=salary+(this.HRA+this.TA+this.DA)*salary;
		return ctcSalary;
	}
}
