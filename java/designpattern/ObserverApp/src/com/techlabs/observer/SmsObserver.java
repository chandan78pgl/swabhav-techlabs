package com.techlabs.observer;

public class SmsObserver implements BalanceChangeObserver{

	@Override
	public void update(double balance) {
		System.out.println("This is an SMS and new balance:- "+balance);
	}

}
