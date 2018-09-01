package com.techlabs.basic;

import java.util.HashMap;

public class Assignment2 {

	static HashMap<String,String> map = new HashMap<String,String>();
	public static void main(String[] args) {
		
		String url = "https://www.swabhavtechlabs.com?user=\"Chandan\"";
		
		testSplit(url);
		testSubstring(url);
		
		System.out.println("-------------------------------------");
		System.out.println("Using Split \n\nUser = "+map.keySet()+"\nCompany = "+map.values());
		
	}

	static void testSubstring(String s) {
		int i,j;
		i=s.indexOf(".");
		
		String s1 = s.substring(i+1,s.length());
		i=s1.indexOf(".");
		String company = s1.substring(0,i);
		System.out.println("------------------------------------");
		System.out.println("Using SubString\n\nCompany = "+company);
		String name = s1.substring(i,s1.length());
		
		j=name.indexOf("\"");
		name=name.substring(j+1,name.length()-1);
		System.out.println("Name = "+name);
	}

	static void testSplit(String s){
		String[] s1 = s.split("[.|\"|\']");
		map.put(s1[3],s1[1]);
		
		for(String str:s1){
			System.out.println("String: "+str);
		}
	}
}
