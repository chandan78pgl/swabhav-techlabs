package com.techlabs.college;

import java.text.ParseException;

public class Professor extends Person {
	private Branch branch;
	private int lectures;
	private double salary;
	private int semester;

	public Professor(int id, String name, String address, String dob,Branch branch, int lectures, double salary, int semester) throws ParseException {
		super(id, name, address, dob);
		this.branch=branch;
		this.lectures=lectures;
		this.salary=salary;
		this.semester=semester;
	}

	public String getBranch() {
		return this.branch.name();
	}

	public double getSalary() {
		return this.salary;
	}

	public int getSemester() {
		return this.semester;
	}

	public String giveSalaryLogic() {
		return "No. of lectures taken: " + this.lectures + "\nTotal salary: "
				+ calculateSalary();
	}

	private double calculateSalary() {
		return this.salary * this.lectures;
	}
}
