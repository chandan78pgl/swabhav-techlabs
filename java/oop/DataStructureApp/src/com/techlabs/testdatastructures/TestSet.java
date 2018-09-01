package com.techlabs.testdatastructures;

import java.util.HashSet;
import java.util.LinkedHashSet;
import java.util.Set;
import java.util.TreeSet;

public class TestSet {

	public static void main(String[] args) {
		String[] strings={"Chandan","Dharmesh","Foo","Bar"};
		
		implementHashSet(strings);
		implementLinkedHashSet(strings);
		implementTreeSet(strings);
	}
	
	public static void implementHashSet(String[] strings){
		HashSet<String> hashStrings=new HashSet<String>();
		
		for(String string:strings){
			hashStrings.add(string);
		}
		
		System.out.println("This is HashSet implementation\n");
		printSet(hashStrings);
		
		System.out.println("Adding \"Foo\" to HashSet: "+hashStrings.add("Foo"));
		printSet(hashStrings);
		
		System.out.println("Adding \"Koo\" to HashSet: "+hashStrings.add("Koo"));
		printSet(hashStrings);
		
		System.out.println("Removing \"Chandan\" from HashSet: "+hashStrings.remove("Chandan"));
		printSet(hashStrings);
		System.out.println("------------------------------------------");
	}
	
	public static void implementLinkedHashSet(String[] strings){
		LinkedHashSet<String> linkedHashStrings=new LinkedHashSet<String>();
		
		for(String string:strings){
			linkedHashStrings.add(string);
		}
		
		System.out.println("This is LinkedHashSet implementation\n");
		printSet(linkedHashStrings);
		System.out.println("Adding \"Foo\" to LinkedHashSet: "+linkedHashStrings.add("Foo"));
		printSet(linkedHashStrings);
		System.out.println("Adding \"Koo\" to LinkedHashSet: "+linkedHashStrings.add("Koo"));
		printSet(linkedHashStrings);
		System.out.println("Removing \"Chandan\" from LinkedHashSet: "+linkedHashStrings.remove("Chandan"));
		printSet(linkedHashStrings);
		System.out.println("------------------------------------------");
	}
	
	public static void implementTreeSet(String[] strings){
		TreeSet<String> treeStrings=new TreeSet<String>();
		
		for(String string:strings){
			treeStrings.add(string);
		}
		
		System.out.println("This is TreeSet implementation\n");
		printSet(treeStrings);
		System.out.println("Adding \"Foo\" to TreeSet: "+treeStrings.add("Foo"));
		printSet(treeStrings);
		System.out.println("Adding \"Koo\" to TreeSet: "+treeStrings.add("Koo"));
		printSet(treeStrings);
		System.out.println("Removing \"Chandan\" from TreeSet: "+treeStrings.remove("Chandan"));
		printSet(treeStrings);
		System.out.println("------------------------------------------");
		
	}
	
	private static void printSet(Set<String> set){
		System.out.println(set.getClass().getSimpleName()+": "+set+"\n");
	}
}