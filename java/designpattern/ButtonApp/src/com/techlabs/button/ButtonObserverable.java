package com.techlabs.button;

public interface ButtonObserverable {
	public void register(ActionObserver o);
	public void remove(ActionObserver o);
	public void notifyAction();
}
