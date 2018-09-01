package com.techlabs.singleton.test;

import com.techlabs.singleton.DataService;

public class TestDataService {
	public static void main(String[] args) {
		DataService service1=DataService.getInstance();
		DataService service2=DataService.getInstance();
		
		service1.processData();
		service2.processData();
	}
}
