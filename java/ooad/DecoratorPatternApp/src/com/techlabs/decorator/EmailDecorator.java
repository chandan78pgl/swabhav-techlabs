package com.techlabs.decorator;

public class EmailDecorator extends BaseDecorator{

	public EmailDecorator(ITransaction transaction) {
		super(transaction);
	}
	
	@Override
	public void deposit(double amount){
		super.deposit(amount);
		System.out.println("Emailing the deposited amount");
	}
	
	@Override
	public void withdraw(double amount){
		super.withdraw(amount);
		System.out.println("Emailing the withdrawal amount");
	}
}
