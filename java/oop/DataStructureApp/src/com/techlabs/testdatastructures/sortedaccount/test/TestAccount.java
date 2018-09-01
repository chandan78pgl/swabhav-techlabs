package com.techlabs.testdatastructures.sortedaccount.test;

import com.techlabs.testdatastructures.sortedaccount.Account;

public class TestAccount {
	public static void main(String[] args){
		Account account1=new Account(101, "Chandan",1000.0);
		
		account1.deposit(500);
		//account1.withdraw(1000);
		//account1.withdraw(200);
		
		System.out.println(account1);
		//printDetails(account1);
	}
	
	private static void printDetails(Account account){
		System.out.println("Account No: "+account.getAccountNo()
				+"\nName: "+account.getName()
				+"\nBalance: "+account.getBalance());
	}
}
