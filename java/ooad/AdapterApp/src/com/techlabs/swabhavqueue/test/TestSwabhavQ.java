package com.techlabs.swabhavqueue.test;

import com.techlabs.swabhavqueue.SwabhavQ;
import com.techlabs.swabhavqueue.SwabhavQueueAdapter;

public class TestSwabhavQ {

	public static void main(String[] args) {
		SwabhavQueueAdapter<String> queueAdapter=new SwabhavQ<String>();
		
		queueAdapter.enQueue("Chandan");
		queueAdapter.enQueue("Dharmesh");
		queueAdapter.enQueue("Parth");
		queueAdapter.enQueue("Brijesh");
		queueAdapter.enQueue("Akash");
		
		System.out.println(queueAdapter.count());
		
		System.out.println(queueAdapter.deQueue());
		
		System.out.println(queueAdapter.count());
		
		for(String name:queueAdapter){
			System.out.println(name);
		}
	}
}
