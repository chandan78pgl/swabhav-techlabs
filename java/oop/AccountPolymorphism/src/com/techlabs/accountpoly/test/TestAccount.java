package com.techlabs.accountpoly.test;

import com.techlabs.accountpoly.Account;
import com.techlabs.accountpoly.CurrentAccount;
import com.techlabs.accountpoly.SavingsAccount;

public class TestAccount {
	public static void main(String[] args) {
		SavingsAccount account1=new SavingsAccount(101,"Chandan",1000);
		SavingsAccount account2=new SavingsAccount(102,"Dharmesh",2000);
		
		account1.deposit(1000);
		//account1.withdraw(2000);
		
		printDetails(account1);
		printDetails(account2);
		
		CurrentAccount curr_acccount1=new CurrentAccount(103,"Chandan2", 10000);
		CurrentAccount curr_acccount2=new CurrentAccount(104,"Dharmesh2", 20000);
		
		curr_acccount1.deposit(10000);
		curr_acccount1.withdraw(24000);
		
		curr_acccount2.withdraw(26000);
		
		printDetails(curr_acccount1);
		printDetails(curr_acccount2);
		
	}
	
	private static void printDetails(Account account){
		System.out.println("Account No: "+account.getAccountNo()
				+"\nName: "+account.getName()
				+"\nBalance: "+account.getBalance());
		System.out.println("----------------------------------");
	}
}
