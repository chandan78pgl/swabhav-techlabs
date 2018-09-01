package com.techlabs.observer.test;

import com.techlabs.observer.Account;
import com.techlabs.observer.EmailObserver;
import com.techlabs.observer.SmsObserver;

public class TestAccount {
	public static void main(String[] args) {
		Account account=new Account("Chandan", 50000.0);
		EmailObserver email=new EmailObserver();
		SmsObserver sms=new SmsObserver();
		
		account.register(email);
		account.register(sms);
		
		account.deposit(1000.0);
		account.deposit(2000.0);
		
		account.remove(sms);
		account.deposit(50000.0);
	}
}
