package com.techlabs.accountpoly;

public abstract class Account {
	private final int accNo;
	private final String name;
	protected double balance;
	
	public Account(int accNo,String name,double balance){
		this.accNo=accNo;
		this.name=name;
		this.balance=balance;
	}
	
	public int getAccountNo(){
		return this.accNo;
	}
	
	public String getName(){
		return this.name;
	}
	
	public double getBalance(){
		return this.balance;
	}
	
	public void deposit(double amount){
		this.balance+=amount;
	}
	
	public abstract void withdraw(double amount);
}
