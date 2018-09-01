package com.techlabs.dom;

import java.util.ArrayList;

public class ControlGroup implements DOMElement{
	private static int space=0;
	private String controlGroupName;
	private ArrayList<DOMElement> children=new ArrayList<DOMElement>();
	
	public ControlGroup(String controlGroupName) {
		this.controlGroupName=controlGroupName;
	}
	
	@Override
	public void display() {
		System.out.println("<"+this.controlGroupName+">");
		
		for(DOMElement element:children){
			element.display();
		}
		
		System.out.println("</"+this.controlGroupName+">");
	}
	
	public void addElement(DOMElement element){
		this.children.add(element);
	}
}
