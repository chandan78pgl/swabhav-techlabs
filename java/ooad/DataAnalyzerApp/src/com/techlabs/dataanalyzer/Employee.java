package com.techlabs.dataanalyzer;

public class Employee {

	private Integer id;
	private String name;
	private String designation;
	private int manager_id;
	private String dateOfJoining;
	private double salary;
	private double commission;
	private int department;

	public Employee(int id, String name, String designation, int manager_id,
			String dateOfJoining, double salary, double commission,
			int department) {

		this.id=id;
		this.name=name;
		this.designation=designation;
		this.manager_id=manager_id;
		this.dateOfJoining=dateOfJoining;
		this.salary=salary;
		this.commission=commission;
		this.department=department;
	}

	public Integer getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public String getDesignation() {
		return designation;
	}

	public int getManager_id() {
		return manager_id;
	}

	public String getDateOfJoining() {
		return dateOfJoining;
	}

	public double getSalary() {
		return salary;
	}

	public double getCommission() {
		return commission;
	}

	public int getDepartment() {
		return department;
	}
	
	@Override
	public boolean equals(Object obj) {
		Employee emp=(Employee)obj;
		if(this.id.equals(emp.getId()))
			return true;
		return false;
	}
	
	@Override
	public int hashCode() {
		return this.id.hashCode();
	}
	
	@Override
	public String toString() {
		String string="\nEmployee ID: "+this.id
				+"\n Name: "+this.name
				+"\n Designation: "+this.designation
				+"\n Manager ID: "+this.manager_id
				+"\n DateOfJoining: "+this.dateOfJoining
				+"\n Salary: "+this.salary
				+"\n Commission: "+this.commission
				+"\n Department: "+this.department
				+"\n---------------------------------";
		return string;
	}
}
