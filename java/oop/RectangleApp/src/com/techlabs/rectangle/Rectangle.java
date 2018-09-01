package com.techlabs.rectangle;

public class Rectangle {
	public int height=1;
	public int width=1;
	public String color="no_color";
	
	public Rectangle(){
		System.out.println("Object Created....!!!");
	}
	
	public void setHeight(int height){
		this.height=validate(height);
	}
	
	public int getHeight(){
		return this.height;
	}
	
	public void setWidth(int width){
		this.width=validate(width);
	}
	
	public int getWidth(){
		return this.width;
	}
	public int calculateArea(){
		return height*width;
	}
	
	public void setBorderColor(String color){
		if(color.equalsIgnoreCase("red") || color.equalsIgnoreCase("blue") || color.equalsIgnoreCase("green"))
			this.color=color;
	}
	
	public String getBorderColor(){
		return this.color;
	}
	
	private int validate(int dimension){
		if(dimension<1)
			dimension=1;
		if(dimension>100)
			dimension=100;
		return dimension;
	}
}