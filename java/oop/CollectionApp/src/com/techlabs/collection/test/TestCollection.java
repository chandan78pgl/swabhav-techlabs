package com.techlabs.collection.test;

import java.util.ArrayList;
import java.util.List;

import com.techlabs.collection.LineItems;

public class TestCollection {

	public static void main(String[] args) {
		List list=new ArrayList();
		
		list.add(new LineItems(101,"Chandan",20,200));
		list.add(new LineItems(102,"Dharmesh",10,100));
		list.add("Dharmesh");
		
		for(Object obj:list){
			LineItems lineItems=(LineItems)obj;
			System.out.println("Total is: "+lineItems.totalCost());
		}
	}
}
