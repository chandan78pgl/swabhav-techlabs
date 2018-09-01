package com.techlabs.annotation;

public class Bar {
	
	public void m1(){
		System.out.println("This is M1 Method");
	}
	public void m2(){
		System.out.println("This is M2 Method");
	}
	@NeedToFix
	public void m3(){
		System.out.println("This is M3 Method");
	}
}
