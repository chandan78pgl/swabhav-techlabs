package com.techlabs.decorator;

public class LogDecorator extends BaseDecorator{
	
	public LogDecorator(ITransaction transaction) {
		super(transaction);
	}
	
	@Override
	public void deposit(double amount){
		super.deposit(amount);
		System.out.println("Login before deposit");
	}
	
	@Override
	public void withdraw(double amount){
		super.withdraw(amount);
		System.out.println("Login before withdraw");
	}
	
}
