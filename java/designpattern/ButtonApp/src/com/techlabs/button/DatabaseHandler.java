package com.techlabs.button;

public class DatabaseHandler implements ActionObserver{
	@Override
	public void update(String action) {
		System.out.println("DatabaseHandler performing Action: "+action);
	}
}
