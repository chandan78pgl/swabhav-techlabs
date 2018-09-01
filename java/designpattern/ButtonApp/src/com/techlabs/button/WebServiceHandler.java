package com.techlabs.button;

public class WebServiceHandler implements ActionObserver{

	@Override
	public void update(String action) {
		System.out.println("WebServiceHandler performing Action: "+action);
	}

}
