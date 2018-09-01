package com.techlabs.decorator.test;

import com.techlabs.decorator.Account;
import com.techlabs.decorator.BaseDecorator;
import com.techlabs.decorator.ITransaction;
import com.techlabs.decorator.EmailDecorator;
import com.techlabs.decorator.LogDecorator;

public class TestDecorator {
	public static void main(String[] args) {
		ITransaction transaction1=new EmailDecorator(new LogDecorator(new Account("Chandan",5000)));
		transaction1.deposit(2000);
		transaction1.withdraw(1000);
		
		ITransaction transaction2=new LogDecorator(new Account("Dharmesh",5000));
		transaction2.deposit(3000);
		
		ITransaction transaction3=new EmailDecorator(new Account("Chandan",4000));
		transaction3.deposit(1000);
		
		ITransaction transaction4=new LogDecorator(new Account("Dharmesh",11000));
		transaction4.withdraw(1000);
	}
}
