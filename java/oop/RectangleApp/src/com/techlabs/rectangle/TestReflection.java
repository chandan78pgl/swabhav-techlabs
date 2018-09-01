package com.techlabs.rectangle;

import java.lang.reflect.Constructor;
import java.lang.reflect.Field;
import java.lang.reflect.Method;

public class TestReflection {

	public static void main(String[] args) {
		Class<?> aclass = Rectangle.class;

		Constructor<?>[] constructors = aclass.getConstructors();
		
		int i;
		
		for(i=0;i<constructors.length;i++){
			System.out.println("Constructors are "+constructors[i].getName());
		}
		
		Method[] method = aclass.getMethods();
		
		for(i=0;i<method.length;i++){
			System.out.println("Methods are "+method[i].getName());
		}
		
		Field[] field = aclass.getFields();  
		
		for(i=0;i<field.length;i++){
			System.out.println("Fields are "+field[i].getName());
		}
		
	}
}
