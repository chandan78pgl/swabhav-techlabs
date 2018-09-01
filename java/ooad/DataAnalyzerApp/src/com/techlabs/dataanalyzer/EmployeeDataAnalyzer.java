package com.techlabs.dataanalyzer;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Map;

public class EmployeeDataAnalyzer {
	private HashSet<Employee> employees=null;
	
	public EmployeeDataAnalyzer(DataParser empParser){
		this.employees=(HashSet<Employee>) empParser.parseData();
	}
	
	public HashSet<Employee> getEmployees(){
		return this.employees;
	}
	
	public Employee showMaxSalaryEmployee(){
		ArrayList<Employee> employeeList=new ArrayList<Employee>(this.employees);
		
		Employee maxSalariedEmployee=employeeList.get(0);
		for(Employee employee:employeeList){
			if(employee.getSalary()>maxSalariedEmployee.getSalary())
				maxSalariedEmployee=employee;
		}
		return maxSalariedEmployee;
	}
	
	public void getTotalNumberOfEmployees(String DSorDP){
		HashMap<String, Integer> employeeMap=new HashMap<String, Integer>();
		
		if(DSorDP.equals("DS")){
			employeeMap=(HashMap<String, Integer>) countByDesignation(employeeMap);
			System.out.println("\nTotal Number of Employees: "+this.employees.size()
					+"\n By Designation: "+employeeMap);
		}else if(DSorDP.equals("DP")){
			employeeMap=(HashMap<String, Integer>) countByDepartment(employeeMap);
			System.out.println("\nTotal Number of Employees: "+this.employees.size()
					+"\n By Department: "+employeeMap);
		}
	}
	
	private Map<String, Integer> countByDepartment(Map<String, Integer> map){
		for(Iterator<Employee> employeeIter=this.employees.iterator();employeeIter.hasNext();){
			Employee employee=(Employee)employeeIter.next();
			
			Integer department=employee.getDepartment();
			
			if(!map.containsKey("Department"+department.toString()))
				map.put("Department"+department,1);
			else
				map.put("Department"+department,map.get("Department"+department)+1);

		}
		return map;
	}
	
	private Map<String, Integer> countByDesignation(Map<String, Integer> map){
		
		for(Iterator<Employee> employeeIter=this.employees.iterator();employeeIter.hasNext();){
			Employee employee=(Employee)employeeIter.next();
			
			String designation=employee.getDesignation();
			
			if(!map.containsKey(designation))
				map.put(designation,1);
			else
				map.put(designation,map.get(designation)+1);
		}
		return map;
	}
}
