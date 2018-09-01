package com.techlabs.decorator;

public class Account implements ITransaction{
	private String name;
	private double balance;
	
	public Account(String name, double balance){
		this.name=name;
		this.balance=balance;
	}
	
	public String getName(){
		return this.name;
	}
	
	public Double getBalance(){
		return this.balance;
	}
	
	@Override
	public void deposit(double amount){
		this.balance+=amount;
	}
	
	@Override
	public void withdraw(double amount){
		this.balance-=amount;
	}
}
