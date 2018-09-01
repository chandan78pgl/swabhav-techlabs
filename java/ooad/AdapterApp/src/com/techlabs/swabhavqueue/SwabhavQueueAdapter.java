package com.techlabs.swabhavqueue;

public interface SwabhavQueueAdapter<T> extends Iterable<T>{
	public void enQueue(Object name);
	public T deQueue();
	public int count();
}
