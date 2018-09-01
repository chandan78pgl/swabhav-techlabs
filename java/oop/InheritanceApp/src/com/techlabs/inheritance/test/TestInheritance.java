package com.techlabs.inheritance.test;

import com.techlabs.inheritance.Boy;
import com.techlabs.inheritance.Infant;
import com.techlabs.inheritance.Kid;
import com.techlabs.inheritance.Man;

public class TestInheritance {
	public static void main(String[] args){
		testMan();
		System.out.println("---------------------------------");
		testBoy();
		System.out.println("---------------------------------");
		testManBoy();
		System.out.println("---------------------------------");
		testPolymorphism();
		System.out.println("---------------------------------");
	}
	
	public static void testMan(){
		Man x=new Man();
		
		x.read();
		x.play();
		x.wish();
	}
	public static void testBoy(){
		Boy x=new Boy();
		
		x.eat();
		x.read();
		x.play();
		x.wish();
	}
	public static void testManBoy(){
		Man x=new Boy();
		
		x.read();
		x.play();
		x.wish();
	}
	
	public static void testPolymorphism(){
		
		atThePark(new Man());
		atThePark(new Boy());
		atThePark(new Kid());
		atThePark(new Infant());
		
	}
	
	public static void atThePark(Man x){
		System.out.print("At the park: ");
		x.play();
	}
}
