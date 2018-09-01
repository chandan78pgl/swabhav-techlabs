package com.techlabs.account.test;

import com.techlabs.account.Account;

public class TestAccount {
	public static void main(String[] args){
		Account account1=new Account(101, "Chandan",1000.0);
		
		account1.deposit(500);
		printDetails(account1);
		try {
			System.out.println("----------------------\nTrying To withdraw");
			//account1.withdraw(1000);
			account1.withdraw(1200);
		} catch (Exception e) {
			System.out.println(e.getMessage()+"\n-------------------------------------");
		}
		printDetails(account1);
	}
	
	private static void printDetails(Account account){
		System.out.println("Account No: "+account.getAccountNo()
				+"\nName: "+account.getName()
				+"\nBalance: "+account.getBalance());
	}
}
