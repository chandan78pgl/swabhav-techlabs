package com.techlabs.factory;

public class BMWFactory implements AutomobileFactory{
	private static BMWFactory bmwFactory;
	
	private BMWFactory() {
		// TODO Auto-generated constructor stub
	}
	
	@Override
	public Automobile make(){
		return new BMW();
	}
	
	public static BMWFactory getInstance(){
		if(bmwFactory==null)
			bmwFactory=new BMWFactory();
		return bmwFactory;
	}
}
