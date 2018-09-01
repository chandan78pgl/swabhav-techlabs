package com.techlabs.accountpoly;

public class CurrentAccount extends Account {
	public CurrentAccount(int accNo,String name,double balance){
		super(accNo,name,balance);
	}

	@Override
	public void withdraw(double amount) {
		if(validateWithdraw(amount)){
			this.balance-=amount;
		}
		else{
			System.out.println("Cannot Withdraw Minimum Balance has to be maintained to 5000 Rs");
		}
	}
	
	private boolean validateWithdraw(double amount){
		if((this.balance-amount)<-5000)
			return false;
		return true;
	}
}
