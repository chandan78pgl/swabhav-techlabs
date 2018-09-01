package com.techlabs.exceptionapp.test;

public class TestBug {
	private static int counter=0;
	public static void main(String[] args) {
		counter++;
		int a=Integer.parseInt(args[0]);
		int b=Integer.parseInt(args[1]);
		int c=a/b;
		
	
		System.out.println("Answer: "+c);
	}	
}
