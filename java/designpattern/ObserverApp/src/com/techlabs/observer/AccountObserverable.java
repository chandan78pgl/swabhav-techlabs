package com.techlabs.observer;

public interface AccountObserverable {
	public void register(BalanceChangeObserver observer);
	public void remove(BalanceChangeObserver observer);
	public void notifyBalance();
}
