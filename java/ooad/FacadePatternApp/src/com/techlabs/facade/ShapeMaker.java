package com.techlabs.facade;

public class ShapeMaker {
	private Shape circle;
	private Shape rectangle;
	private Shape square;
	
	public ShapeMaker(){
		circle=new Circle();
		square=new Square();
		rectangle=new Rectangle();
	}
	
	public void drawCircle(){
		circle.draw();
	}
	
	public void drawSquare(){
		square.draw();
	}
	
	public void drawRectangle(){
		rectangle.draw();
	}
}
