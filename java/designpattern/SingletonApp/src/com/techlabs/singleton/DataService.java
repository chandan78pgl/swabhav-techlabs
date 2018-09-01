package com.techlabs.singleton;

public class DataService {
	private static DataService bucket;
	
	public DataService(){
		System.out.println("Dataservice created.");
	}
	
	public static DataService getInstance(){
		if(bucket==null)
			bucket= new DataService();
		return bucket;
	}
	
	public void processData(){
		System.out.println("Process data by "+this.hashCode());
	}
}
