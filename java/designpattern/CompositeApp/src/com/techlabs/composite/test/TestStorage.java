package com.techlabs.composite.test;

import com.techlabs.composite.CustomFile;
import com.techlabs.composite.Folder;

public class TestStorage {
	public static void main(String[] args) {
		Folder root=new Folder("root");
		root.addStorageItem(new CustomFile("oad", "Java File"));
		
		Folder subFolder1=new Folder("subFolder1");
		subFolder1.addStorageItem(new CustomFile("composite Pattern", "Class file"));

		root.addStorageItem(subFolder1);
		root.showDetails();
		System.out.println(root.getSize());
	}
}
