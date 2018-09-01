package com.techlabs.composite;

import java.util.ArrayList;

public class Folder implements StorageItems{
	private String folderName;
	private int size;
	private ArrayList<StorageItems> contains=new ArrayList<StorageItems>();
	
	public Folder(String folderName) {
		this.folderName=folderName;
	}
	
	public void addStorageItem(StorageItems item){
		this.contains.add(item);
	}
	
	@Override
	public void showDetails() {
		System.out.println("Folder Name: "+this.folderName);
		for(StorageItems items: contains){
			items.showDetails();
		}
	}
	
	public Integer getSize(){
		return this.contains.size();
	}
}
