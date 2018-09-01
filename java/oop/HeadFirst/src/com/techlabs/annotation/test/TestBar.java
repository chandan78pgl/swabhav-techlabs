package com.techlabs.annotation.test;

import java.lang.reflect.Method;
import java.util.ArrayList;
import java.util.List;

import com.techlabs.annotation.Bar;
import com.techlabs.annotation.NeedToFix;

public class TestBar {
	public static void main(String[] args){
		Bar bar=new Bar();		
		List<Method> method=new ArrayList<Method>();
		
		Method[] allmethods = bar.getClass().getMethods();
			
		for(Method tmethod:allmethods){
			if(tmethod.isAnnotationPresent(NeedToFix.class)){
				method.add(tmethod);
			}
		}
		
		NeedToFix needToFix;
		for(Method list:method){
			needToFix=list.getDeclaredAnnotation(NeedToFix.class);
			
			System.out.println("Annoted Methods : "+list.getName()
					+"\nTheir Annotation : "+needToFix.value());
		}
	}
}
