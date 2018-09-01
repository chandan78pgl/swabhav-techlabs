package com.techlabs.factory;

public class TeslaFactory implements AutomobileFactory{
	private static TeslaFactory teslaFactory;
	
	private TeslaFactory() {
		// TODO Auto-generated constructor stub
	}
	
	@Override
	public Automobile make(){
		return new Tesla();
	}
	
	public static TeslaFactory getInstance(){
		if(teslaFactory==null)
			teslaFactory=new TeslaFactory();
		return teslaFactory;
	}
}
