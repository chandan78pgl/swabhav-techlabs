package com.techlabs.student.test;

import java.util.HashMap;
import java.util.Map.Entry;

import com.techlabs.student.Student;

public class TestStudent{
	private static HashMap<Student,Student> studentMap =new HashMap<Student, Student>();
	
	public static void main(String[] args) {
		
		Student student1=new Student(101, "Chandan", 10);
		Student student2=new Student(102, "Dharmesh", 11);
		Student student3=new Student(101, "Foo", 12);
		Student student4=new Student(102, "Bar", 12);
				
		studentMap.put(student1, student1);
		studentMap.put(student2, student2);
		studentMap.put(student3, student3);
		studentMap.put(student4, student4);
		
		for(Entry<Student, Student> i:studentMap.entrySet())
			System.out.println(i);
		
		System.out.println(studentMap.get(student1));
		
	}
}
