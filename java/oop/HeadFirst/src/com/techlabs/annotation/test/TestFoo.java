package com.techlabs.annotation.test;

import java.lang.reflect.Method;
import java.util.ArrayList;
import java.util.List;

import com.techlabs.annotation.Foo;
import com.techlabs.annotation.SwabhavTestCase;;

public class TestFoo {
	public static void main(String[] args){
		Foo foo=new Foo();		
		List<Method> method=new ArrayList<Method>();
		
		Method[] allmethods = foo.getClass().getMethods();
			
		for(Method tmethod:allmethods){
			if(tmethod.isAnnotationPresent(SwabhavTestCase.class)){
				method.add(tmethod);
			}
		}
		
		SwabhavTestCase swabhavTestCase;
		for(Method list:method){
			swabhavTestCase=list.getDeclaredAnnotation(SwabhavTestCase.class);
			
			System.out.println("Annoted Methods : "+list.getName());
			if(swabhavTestCase.value()){
				System.out.println(list.getName()+" method is passed");
			}
			else{
				System.out.println(list.getName()+" method is Failed");
			}
		}
	}
}
