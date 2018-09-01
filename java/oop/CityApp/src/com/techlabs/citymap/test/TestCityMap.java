package com.techlabs.citymap.test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.Map.Entry;

import com.techlabs.citymap.City;
import com.techlabs.citymap.CityMap;

public class TestCityMap {
	public static void main(String[] args) throws NumberFormatException, IOException {
		CityMap map=new CityMap();
	
		initializeCityMap(map);
		
		searchConsole(map);
	}
	
	public static void initializeCityMap(CityMap map){
		map.addCity("MUM", "Mumbai");
		map.addCity("ST", "Surat");
		map.addCity("VAPI", "Vapi");
		map.addCity("MON", "Monday");
		map.addCity("MAL", "Maldi");
	}
	
	public static void searchConsole(CityMap map) throws NumberFormatException, IOException{
		boolean isExit=false;
		System.out.println("Search Console Started For Map......");
		
		while(!isExit){
			System.out.println("\nSelect any option BELOW:"
					+ "\n1. to Search."
					+ "\n2. Quit"
					+ "\n Enter Choice: ");
			
			int choice = 0;
			final int add=1,quit=2;
			
			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
			choice = Integer.parseInt(br.readLine());
			
			switch (choice) {
			case add:
				System.out.println("Enter City Code: ");
				BufferedReader br1 = new BufferedReader(new InputStreamReader(System.in));
				String cityCode = br1.readLine();
				
				HashMap<City, City> hashMap=map.search(cityCode);
				
				System.out.println("--------------------------------\nCities BELOW:\n");
				for(Entry<City, City> cities: hashMap.entrySet()){
					System.out.println("-----------\n"+cities.getValue());
				}
				
				break;
			case quit:
				System.out.println("The program is now Closed");
				isExit = true;
				break;
			default:
				System.out.println("You have to Select  an option given above");
				break;
			}
		}
	}
}
