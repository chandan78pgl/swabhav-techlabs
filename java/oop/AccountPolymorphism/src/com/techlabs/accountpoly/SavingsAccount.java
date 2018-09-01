package com.techlabs.accountpoly;

public class SavingsAccount extends Account{
	public SavingsAccount(int accNo,String name,double balance){
		super(accNo,name,balance);
	}

	@Override
	public void withdraw(double amount) {
		if(validateWithdraw(amount)){
			this.balance-=amount;
		}
		else{
			System.out.println("Cannot Withdraw Minimum Balance has to be maintained to 500 Rs");
		}
	}
	
	private boolean validateWithdraw(double amount){
		if((this.balance-amount)<500)
			return false;
		return true;
	}
}
