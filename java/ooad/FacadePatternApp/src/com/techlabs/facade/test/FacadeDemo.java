package com.techlabs.facade.test;

import com.techlabs.facade.ShapeMaker;

public class FacadeDemo {
	public static void main(String[] args) {
		ShapeMaker shapeMaker=new ShapeMaker();
		
		shapeMaker.drawCircle();
		shapeMaker.drawSquare();
		shapeMaker.drawRectangle();
	}
}
