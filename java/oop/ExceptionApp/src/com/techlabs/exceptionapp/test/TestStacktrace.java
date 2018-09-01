package com.techlabs.exceptionapp.test;

public class TestStacktrace {
	public static void main(String[] args) {
		try {
			m1();
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		System.out.println("End of main");
	}

	public static void m1() throws Exception{
		System.out.println();
		m2();
	}
	
	public static void m2() throws Exception{
		m3();
	}
	
	public static void m3() throws Exception{
		throw new Exception("Unknown Error");
	}
}
