package com.techlabs.factory;

public class AudiFactory implements AutomobileFactory{
	private static AudiFactory audiFactory;
	
	private AudiFactory() {
		// TODO Auto-generated constructor stub
	}
	
	@Override
	public Automobile make(){
		return new Audi();
	}
	
	public static AudiFactory getInstance(){
		if(audiFactory==null)
			audiFactory=new AudiFactory();
		return audiFactory;
	}
}
