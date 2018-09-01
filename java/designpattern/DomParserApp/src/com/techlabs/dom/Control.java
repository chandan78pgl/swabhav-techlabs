package com.techlabs.dom;

public class Control implements DOMElement{
	private String controlName;
	private String controlType;
	
	public Control(String controlName,String controlType) {
		this.controlName=controlName;
		this.controlType=controlType;
	}

	@Override
	public void display() {
		System.out.println("<"+this.controlName+" type=\""+this.controlType+"\""+"/>");
	}
	
	
}
