package com.techlabs.simplefactory;

public class AutomobileFactory {
	private static AutomobileFactory autoFactory;
	
	private AutomobileFactory(){
		System.out.println("Object Created....");
	}
	
	public Automobile make(AutoType auto){
		
		if(auto==AutoType.AUDI)
			return new Audi();
		if(auto==AutoType.BMW)
			return new BMW();
		if(auto==AutoType.TESLA)
			return new Tesla();
		
		return null;
	}
	
	public static AutomobileFactory getInstance(){
		if(autoFactory==null)
			autoFactory=new AutomobileFactory();
		return autoFactory;
	}
}
