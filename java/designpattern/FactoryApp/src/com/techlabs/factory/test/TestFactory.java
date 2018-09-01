package com.techlabs.factory.test;

import java.io.FileReader;
import java.io.IOException;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.Properties;

import com.techlabs.factory.Automobile;
import com.techlabs.factory.AutomobileFactory;

public class TestFactory {

	public static void main(String[] args) throws IOException, ClassNotFoundException, InstantiationException, IllegalAccessException, NoSuchMethodException, SecurityException, IllegalArgumentException, InvocationTargetException {
		Properties prop=new Properties();
		String propFileName="resources/config.properties";
		
		FileReader fr=new FileReader(propFileName);
		
		if(fr!=null)
			prop.load(fr);
	
		
		@SuppressWarnings("unchecked")
		Class<? extends AutomobileFactory> testFactory=(Class<? extends AutomobileFactory>) Class.forName(prop.getProperty("app.currentfactory"));
		Method instanceMethod =testFactory.getDeclaredMethod("getInstance");
		
		AutomobileFactory factory=(AutomobileFactory) instanceMethod.invoke(testFactory);
		
		Automobile automobile=factory.make();
		
		automobile.start();
		automobile.stop();
	}
}
