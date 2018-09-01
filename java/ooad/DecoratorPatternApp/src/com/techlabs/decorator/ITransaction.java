package com.techlabs.decorator;

public interface ITransaction {
	public void deposit(double amount);
	public void withdraw(double amount);
}
