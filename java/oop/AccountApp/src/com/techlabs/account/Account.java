package com.techlabs.account;

public class Account {
	private int accNo;
	private String name;
	private double balance=500.0;
	private static int count;
	
	static{
		count=100;
		System.out.println("Inside Static");
	}
	
	public Account(int accNo,String name,double balance){
		this(accNo,name);
		this.balance=balance;
	}
	
	public Account(int accNo,String name){
		this();
		this.accNo=accNo;
		this.name=name;
	}
	
	public Account(){
		Account.count++;
		System.out.println("Object Created.");
	}
	
	public void deposit(double amount){
		this.balance+=amount;
	}
	
	public void withdraw(double amount){
		if(validateWithdraw(amount)){
			this.balance-=amount;
		}
		else{
			System.out.println("Cannot Withdraw Minimum Balance has to be maintained to 500 Rs");
		}
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
	
	public int getCount(){
		return Account.count;
	}
	
	public static int HeadCount(){
		return Account.count;
	}
	
	public boolean validateWithdraw(double amount){
		if((this.balance-amount)<500)
			return false;
		return true;
	}
	
	@Override
	public String toString(){
		return "Child Class\n Account No: "+this.accNo
				+" - Name: "+this.name
				+" - Balance "+this.balance
				+"\nParent Class\n "+super.toString();
	}
}
