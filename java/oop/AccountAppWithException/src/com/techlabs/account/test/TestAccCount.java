package com.techlabs.account.test;

import com.techlabs.account.Account;

public class TestAccCount {
	public static void main(String[] args){
		Account account1 = new Account(102,"Chandan",5000.0);
		Account account2 = new Account(101,"Dharmesh",5000.0);
		
		System.out.println("Count = "+account1.getCount());
		System.out.println("Count = "+Account.HeadCount());
		
		System.out.println("Count = "+account2.getCount());
		System.out.println("Count = "+Account.HeadCount());
	}
}
