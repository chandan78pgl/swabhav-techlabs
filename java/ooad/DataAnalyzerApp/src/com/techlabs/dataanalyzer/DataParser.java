package com.techlabs.dataanalyzer;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Set;

public class DataParser {
	private ArrayList<String> empData=new ArrayList<String>();
	
	public DataParser(Loader loader) throws FileNotFoundException, IOException{
		empData=(ArrayList<String>) loader.loadData();
	}
	
	public Set<Employee> parseData(){
		ArrayList<Employee> employeeList=new ArrayList<Employee>();
		String[] string={};
		int index=0;
		
		while(index<empData.size()){
			string=empData.get(index).split("[,]");

			if(string[3].equals("NULL")){
				string[3]="0";
			}
			
			if(string[6].equals("NULL")){
				string[6]="0.0";
			}
			
			int id=Integer.parseInt(string[0]);
			String name=string[1];
			String designation=string[2];			
			int manager_id=Integer.parseInt(string[3]);
			String dateOfJoining=string[4];
			double salary=Double.parseDouble(string[5]);
			double commission=Double.parseDouble(string[6]);
			int department=Integer.parseInt(string[7]);

			employeeList.add(new Employee(id, name, designation, manager_id, dateOfJoining, salary, commission, department));
			index++;
		}
		return new HashSet<Employee>(employeeList);
	}
}
