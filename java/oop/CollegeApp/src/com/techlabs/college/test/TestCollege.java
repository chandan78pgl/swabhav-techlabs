package com.techlabs.college.test;

import java.text.ParseException;

import com.techlabs.college.Branch;
import com.techlabs.college.Person;
import com.techlabs.college.Professor;
import com.techlabs.college.Student;

public class TestCollege {
	public static void main(String[] args) throws ParseException {
		Person dipen=new Professor(101, "Dipen", "Dahod", "15/05/1989", Branch.COMPUTER, 12,2000.0, 8);
		Person chandan=new Student(140180, "Chandan", "Surat", "25/11/1995", Branch.COMPUTER, 8);
		
		printDetails(chandan);
		printDetails(dipen);
	}
	
	public static void printDetails(Person person){
		if(person instanceof Professor){
			Professor professor=(Professor)(person);
			
			System.out.println("ID: "+professor.getId()
					+"\nName: "+professor.getName()
					+"\nAddress: "+professor.getAddress()
					+"\nDateOfBirth: "+professor.getDateOfBirth()
					+"\nBranch: "+professor.getBranch()
					+"\nSemester: "+professor.getSemester()
					+"\nBasic Salary: "+professor.getSalary()
					+"\nSalary Logic: \n"+professor.giveSalaryLogic()
					+"\n--------------------------------------------------------");
		}
		else if(person instanceof Student){
			Student student=(Student)(person);
			
			System.out.println("ID: "+student.getId()
					+"\nName: "+student.getName()
					+"\nAddress: "+student.getAddress()
					+"\nDateOfBirth: "+student.getDateOfBirth()
					+"\nBranch: "+student.getBranch()
					+"\nSemester: "+student.getSemester()
					+"\n--------------------------------------------------------");
		}
	}
}
