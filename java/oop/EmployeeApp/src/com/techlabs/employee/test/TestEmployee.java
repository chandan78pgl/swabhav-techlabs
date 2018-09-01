package com.techlabs.employee.test;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

import com.techlabs.employee.Developer;
import com.techlabs.employee.Employee;
import com.techlabs.employee.ExportEmployee;
import com.techlabs.employee.Manager;
import com.techlabs.employee.Tester;

public class TestEmployee {
	public static void main(String[] args) throws IOException {
		Manager manager = new Manager("Chandan", 20000);
		Developer developer = new Developer("Satish", 15000);
		Tester tester = new Tester("Viren", 10000);

		printDetails(manager);
		printDetails(developer);
		printDetails(tester);
	}

	private static void printDetails(Employee employee) throws IOException {
		System.out.println("Employee ID: " + employee.getEmployeeId()
				+ "\nName: " + employee.getName() + "\nCTCSalary: "
				+ employee.getSalary() + "\nAllowance:- "
				+ employee.getAllowance());
		System.out.println("----------------------------------");
		
		String string="\nEmployee ID: " + employee.getEmployeeId()
				+"\nName: " + employee.getName()
				+"\nCTCSalary: "+ employee.getSalary()
				+"\nAllowance:- "+ employee.getAllowance();

		ExportEmployee.exportToHtmlFile(string);
		ExportEmployee.exportAllToHtmlFile(string);
	}
}
