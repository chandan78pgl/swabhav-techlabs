package com.techlabs.observer;

public class EmailObserver implements BalanceChangeObserver{

	@Override
	public void update(double balance) {
		// TODO Auto-generated method stub
		System.out.println("This is an Email and new balance:- "+balance);
	}

}
