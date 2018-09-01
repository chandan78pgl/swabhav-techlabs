package com.techlabs.observer;

import java.util.ArrayList;

public class Account implements AccountObserverable{
	private ArrayList<BalanceChangeObserver> observerList=new ArrayList<BalanceChangeObserver>();
	
	private String name;
	private double balance;
	
	public Account(String name,double balance){
		this.name=name;
		this.balance=balance;
	}
	
	public String getName(){
		return this.name;
	}
	
	public Double getBalance(){
		return this.balance;
	}
	
	public void deposit(double balance){
		this.balance+=balance;
		notifyBalance();
	}

	@Override
	public void register(BalanceChangeObserver observer) {
		observerList.add(observer);
	}

	@Override
	public void remove(BalanceChangeObserver observer) {
		observerList.remove(observer);
	}

	@Override
	public void notifyBalance() {
		for(BalanceChangeObserver observer:observerList){
			observer.update(this.balance);
		}
	}
	
	
}
