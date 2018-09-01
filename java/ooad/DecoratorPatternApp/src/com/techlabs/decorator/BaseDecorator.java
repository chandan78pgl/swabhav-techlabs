package com.techlabs.decorator;

public abstract class BaseDecorator implements ITransaction{
	ITransaction transaction;

	public BaseDecorator(ITransaction transaction){
		this.transaction=transaction;
	}
	
	@Override
	public void deposit(double amount) {
		transaction.deposit(amount);
	}

	@Override
	public void withdraw(double amount) {
		transaction.withdraw(amount);
	}
	
	
}
