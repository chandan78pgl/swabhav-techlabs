package com.techlabs.inheritance;

public class Boy extends Man{
	
	public Boy(){
		System.out.println("Boy Created");
	}
	public void eat(){
		System.out.println("Boy is eating.....");
	}
	
	@Override
	public void play(){
		System.out.println("Boy is playing.....");
	}
}
