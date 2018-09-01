package com.techlabs.basic;

public class TestArray {
	public static void main(String[] args){
		int marks[]={20,25,90,35,80,100};
		String names[]={"chandan","dharmesh","brijesh","akash"};
		
		for(int mark:marks){
			System.out.println("marks = "+mark);
		}
		
		for(String name:names){
			System.out.println("Names: "+name);
		}
	}
}
