package com.techlabs.circle;

public class Circle {	
	
	private float radius;
	private BorderOptionType bStyle;
	
	public Circle(float radius,BorderOptionType bStyle) {
		this.radius=radius;
		this.bStyle=bStyle;
	}
	
	public float getRadius(){
		return this.radius;
	}
	
	public BorderOptionType getBorderStyle(){
		return bStyle;
	}
	
	public float area(){
		return (float) (2*Math.PI*radius*radius);
	}
}
