package com.techlabs.annotation;

public class Foo {
	
	@SwabhavTestCase(value=true)
	public void m1(){
		System.out.println("This is M1 Method");
	}
	public void m2(){
		System.out.println("This is M2 Method");
	}
	
	@SwabhavTestCase(value=true)
	public void m3(){
		System.out.println("This is M3 Method");
	}
	@SwabhavTestCase(value=true)
	public void m4(){
		System.out.println("This is M3 Method");
	}
	@SwabhavTestCase(value=false)
	public void m5(){
		System.out.println("This is M3 Method");
	}
}
