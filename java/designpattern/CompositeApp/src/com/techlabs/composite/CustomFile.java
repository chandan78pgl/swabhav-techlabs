package com.techlabs.composite;

public class CustomFile implements StorageItems{
	private String fileName;
	private String fileExtenion;
	
	public CustomFile(String fileName,String fileExtension) {
		this.fileName=fileName;
		this.fileExtenion=fileExtension;
	}
	
	@Override
	public void showDetails() {
		System.out.println("FileName: "+this.fileName+" - FileExtension: "+this.fileExtenion);
	}
	
}
