package com.techlabs.prolinkedlist.test;

import com.techlabs.prolinkedlist.ProLinkedList;

public class TestProLinkedList {
	public static void main(String[] args) {
		ProLinkedList<String> list=new ProLinkedList<String>();
		
		list.add("Chandan");
		list.add("Dharmesh");
		list.add("Foo");
		
		System.out.println(list.get(1));
		System.out.println(list.remove(1));
		System.out.println(list.size());
		System.out.println(list.get(1));
	}
}
