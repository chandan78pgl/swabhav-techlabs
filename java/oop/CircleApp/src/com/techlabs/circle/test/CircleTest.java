package com.techlabs.circle.test;

import com.techlabs.circle.BorderOptionType;
import com.techlabs.circle.Circle;

public class CircleTest {
	
	public static void main(String[] args){
		Circle circle=new Circle(10,BorderOptionType.DOTTED);
		Circle[] circle1=new Circle[3];
		
		circle1[0]=new Circle(5,BorderOptionType.DOUBLE);
		circle1[1]=new Circle(2,BorderOptionType.SINGLE);
		circle1[2]=new Circle(4,BorderOptionType.DOTTED);
		
		printDetails(circle1[0]);
		printDetails(circle1[1]);
		printDetails(circle1[2]);
		
		System.out.println("\nSUM = "
				+(circle1[0].area()+circle1[1].area()+circle1[2].area()));
		System.out.println("------------------------------------");
		
		System.out.println("Area = "+circle.area()
				+"\nStyle = "+circle.getBorderStyle());		
	}
	
	private static void printDetails(Circle circle){
		System.out.println("\nArea = "+circle.area()
				+"  Style = "+circle.getBorderStyle());
		System.out.println("------------------------------------");
	}
}
