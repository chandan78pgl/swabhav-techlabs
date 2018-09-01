package com.techlabs.swabhavqueue;

import java.util.Iterator;
import java.util.LinkedList;

public class SwabhavQ<T> implements SwabhavQueueAdapter<T>{

	private LinkedList<T> queue;
	
	public SwabhavQ() {
		this.queue=new LinkedList<T>();
	}
	
	@SuppressWarnings("unchecked")
	@Override
	public void enQueue(Object name) {
		queue.addLast((T) name);
	}

	@Override
	public T deQueue() {
		
		return queue.removeFirst();
	}

	@Override
	public int count() {
		
		return queue.size();
	}

	@Override
	public Iterator<T> iterator() {
		
		return queue.iterator();
	}

}
