package com.techlabs.collection.test;

import java.util.ArrayList;
import java.util.List;

import com.techlabs.collection.LineItems;

public class TestGenericCollection {
	public static void main(String[] args) {
		List<LineItems> list=new ArrayList<LineItems>();
		
		list.add(new LineItems(101,"Chandan",20,200));
		list.add(new LineItems(102,"Dharmesh",10,100));
		list.add(new LineItems(103,"Foo",10,30));
		
		for(LineItems lineItems:list){
			System.out.println("Total is: "+lineItems.totalCost());
		}
	}
}
