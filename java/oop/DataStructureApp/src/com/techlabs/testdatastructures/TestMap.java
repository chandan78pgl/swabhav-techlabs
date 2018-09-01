package com.techlabs.testdatastructures;

import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.TreeMap;

public class TestMap {
	public static void main(String[] args) {
		String[] strings={"Chandan","Dharmesh","Foo","Bar"};
		
		implementHashMap(strings);
		implementLinkedHashMap(strings);
		implementTreeMap(strings);
	}
	
	public static void implementHashMap(String[] strings){
		HashMap<String,Integer> hashStrings=new HashMap<String, Integer>();
		
		int value=1;
		for(String string:strings){
			hashStrings.put(string,value);
			value++;
		}
		
		System.out.println("This is HashMap implementation\n");
		printMap(hashStrings);
		
		System.out.println("Putting \"Foo and 3\" in HashMap: "+hashStrings.put("Foo", 3));
		printMap(hashStrings);
		
		System.out.println("Putting \"Koo and 3\" in HashMap: "+hashStrings.put("Koo", 3));
		printMap(hashStrings);
		
		System.out.println("Getting \"Koo value\" in HashMap: "+hashStrings.get("Koo"));
		
		System.out.println("\nRemoving \"Chandan and 1\" in HashMap: "+hashStrings.remove("Chandan"));
		printMap(hashStrings);
		
		System.out.println("Getting \"Chandan value\" in HashMap: "+hashStrings.get("Chandan"));
		
		
		System.out.println("---------------------------------------------");
		
	}
	
	public static void implementLinkedHashMap(String[] strings){
		LinkedHashMap<String, Integer> linkedHashStrings=new LinkedHashMap<String, Integer>();
		
		int value=1;
		for(String string:strings){
			linkedHashStrings.put(string,value);
			value++;
		}
		
		System.out.println("This is LinkedHashMap implementation\n");
		printMap(linkedHashStrings);
		
		System.out.println("Putting \"Foo and 3\" in LinkedHashMap: "+linkedHashStrings.put("Foo", 3));
		printMap(linkedHashStrings);
		
		System.out.println("Putting \"Koo and 3\" in LinkedHashMap: "+linkedHashStrings.put("Koo", 3));
		printMap(linkedHashStrings);
		
		System.out.println("Getting \"Koo value\" in LinkedHashMap: "+linkedHashStrings.get("Koo"));
		
		System.out.println("\nRemoving \"Chandan and 1\" in LinkedHashMap: "+linkedHashStrings.remove("Chandan"));
		printMap(linkedHashStrings);
		
		System.out.println("Getting \"Chandan value\" in LinkedHashMap: "+linkedHashStrings.get("Chandan"));
		
		System.out.println("---------------------------------------------");
	}
	
	public static void implementTreeMap(String[] strings){
		TreeMap<String, Integer> treeStrings=new TreeMap<String, Integer>();
		
		int value=1;
		for(String string:strings){
			treeStrings.put(string,value);
			value++;
		}
		
		System.out.println("This is LinkedHashMap implementation\n");
		printMap(treeStrings);
		
		System.out.println("Putting \"Foo and 3\" in TreeMap: "+treeStrings.put("Foo", 3));
		printMap(treeStrings);
		
		System.out.println("Putting \"Koo and 3\" in TreeMap: "+treeStrings.put("Koo", 3));
		printMap(treeStrings);
		
		System.out.println("Getting \"Koo value\" in TreeMap: "+treeStrings.get("Koo"));
		
		System.out.println("\nRemoving \"Chandan and 1\" in TreeMap: "+treeStrings.remove("Chandan"));
		printMap(treeStrings);
		
		System.out.println("Getting \"Chandan value\" in TreeMap: "+treeStrings.get("Chandan"));
		
		System.out.println("---------------------------------------------");
	}
	
	private static void printMap(Map<String,Integer> map){
		System.out.println(map.getClass().getSimpleName()+": "+map+"\n");
	}
}
