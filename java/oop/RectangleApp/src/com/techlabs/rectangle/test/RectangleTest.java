package com.techlabs.rectangle.test;

import com.techlabs.rectangle.Rectangle;

public class RectangleTest {

	public static void main(String[] args) {
		testObjectRef();
		testAnonymousObject();
	}

	private static void testAnonymousObject() {
		System.out.println("Anonymous object: "+new Rectangle().calculateArea());
		printDetails(new Rectangle());
	}

	private static void testObjectRef() {
		Rectangle rectangle1, rectangle2, rectangle3;

		rectangle1 = new Rectangle();
		rectangle2 = new Rectangle();
		rectangle3 = new Rectangle();

		// rectangle 1 details
		rectangle1.setHeight(500);
		rectangle1.setWidth(-100);
		rectangle1.setBorderColor("RED");

		// rectangle 2 details
		rectangle2 = rectangle1;
		rectangle2.setHeight(50); 
		// rectangle2=null;
		
		// rectangle 3 details
		rectangle3.setHeight(20);
		rectangle3.setWidth(8);

		printDetails(rectangle1);
		printDetails(rectangle2);
		printDetails(rectangle3);
	}

	private static void printDetails(Rectangle rectangle) {
		System.out.println("Height = " + rectangle.getHeight() + "\nWidth = "
				+ rectangle.getWidth() + "\nArea = "
				+ rectangle.calculateArea()
				+ "\n"+rectangle.getBorderColor());
		System.out.println("-------------------------------------");
	}
}