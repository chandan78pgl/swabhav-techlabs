package com.techlabs.simplefactory.test;

import com.techlabs.simplefactory.AutoType;
import com.techlabs.simplefactory.Automobile;
import com.techlabs.simplefactory.AutomobileFactory;

public class TestAutomobileFactory {
	public static void main(String[] args) {
		AutomobileFactory factory=AutomobileFactory.getInstance();
		
		Automobile auto=factory.make(AutoType.TESLA);
		
		auto.start();
		auto.stop();
		
		Automobile auto2=factory.make(AutoType.AUDI);
		auto2.start();
		auto2.stop();
		
		System.out.println(auto2.getClass());
	}
}
