package com.techlabs.dom.test;

import com.techlabs.dom.Control;
import com.techlabs.dom.ControlGroup;

public class TestDomParser {
	public static void main(String[] args) {
		ControlGroup html=new ControlGroup("html");
		ControlGroup body=new ControlGroup("body");
		ControlGroup div=new ControlGroup("div");
		
		Control input=new Control("input","text");

		div.addElement(input);

		body.addElement(div);
		
		html.addElement(body);
		
		html.display();
	}
}
