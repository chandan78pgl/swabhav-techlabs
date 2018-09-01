package com.techlabs.button.test;

import com.techlabs.button.Button;
import com.techlabs.button.DatabaseHandler;
import com.techlabs.button.WebServiceHandler;

public class TestButton {
	public static void main(String[] args) {
		Button button=new Button("Delete&Add", 2, 6);
		WebServiceHandler webHandler=new WebServiceHandler();
		DatabaseHandler dbHandler=new DatabaseHandler();
		
		button.register(webHandler);
		button.register(dbHandler);
		
		button.press();
		button.press();
		
		button.remove(webHandler);
		button.press();
	}
}
