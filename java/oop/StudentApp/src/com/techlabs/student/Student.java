package com.techlabs.student;

public class Student{
	private int rollno;
	private String name;
	private Integer standard;
	
	public Student(int rollno,String name,int standard){
		this.rollno=rollno;
		this.name=name;
		this.standard=standard;
	}
	
	public int getRollno(){
		return this.rollno;
	}
	
	public String getName(){
		return this.name;
	}
	
	public Integer getStandard(){
		return this.standard;
	}
	
	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Student other = (Student) obj;
		if (rollno != other.rollno)
			return false;
		if (standard == null) {
			if (other.standard != null)
				return false;
		} else if (!standard.equals(other.standard))
			return false;
		return true;
	}
	
	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + rollno;
		result = prime * result
				+ ((standard == null) ? 0 : standard.hashCode());
		return result;
	}
	
	@Override
	public String toString() {
		return " RollNo: "+this.rollno
				+" - Name: "+this.name
				+" - Standard: "+this.standard
				+" ";
	}
}
