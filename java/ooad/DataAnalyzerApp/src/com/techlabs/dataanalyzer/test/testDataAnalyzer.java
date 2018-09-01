package com.techlabs.dataanalyzer.test;

import java.io.FileNotFoundException;
import java.io.IOException;

import com.techlabs.dataanalyzer.DataParser;
import com.techlabs.dataanalyzer.EmployeeDataAnalyzer;
import com.techlabs.dataanalyzer.FileLoader;
import com.techlabs.dataanalyzer.URLLoader;

public class testDataAnalyzer {
	public static void main(String[] args) throws FileNotFoundException, IOException {
		
		EmployeeDataAnalyzer emp_analyzer=new EmployeeDataAnalyzer(new DataParser(new URLLoader()));
		System.out.println(emp_analyzer.showMaxSalaryEmployee());
		
		emp_analyzer.getTotalNumberOfEmployees("DS");	
	}
}
