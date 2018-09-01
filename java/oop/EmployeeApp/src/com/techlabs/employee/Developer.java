package com.techlabs.employee;

public class Developer extends Employee {
	private double salary=this.basicSalary;
	
	public Developer(String name, double salary) {
		super(name, salary);
		this.HRA=0.2;
		this.TA=0.3;
	}
	
	@Override
	public String getAllowance(){
		return "\nHRA: "+this.HRA*salary
				+"\nTA: "+this.TA*salary;
	}
	
	@Override
	public double getSalary() {
		double ctcSalary=salary+(this.HRA+this.TA)*salary;
		return ctcSalary;
	}
}
