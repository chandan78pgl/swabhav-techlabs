package com.techlabs.employee;

public class Tester extends Employee {
	private double salary=this.basicSalary;
	
	public Tester(String name, double salary) {
		super(name, salary);
		this.HRA=0.2;
	}
	
	@Override
	public String getAllowance(){
		return "\nHRA: "+this.HRA*salary;
	}

	@Override
	public double getSalary() {
		double ctcSalary=salary+(this.HRA)*salary;
		return ctcSalary;
	}

	
}
