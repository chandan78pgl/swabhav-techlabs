package com.techlabs.citymap;

import java.util.HashMap;
import java.util.Map.Entry;

public class CityMap {
	private HashMap<City,City> cityMap=new HashMap<City, City>();
	
	public void addCity(String cityCode,String cityDescription){
		City city=new City(cityCode,cityDescription);
		cityMap.put(city, city);
	}

	public HashMap<City,City> search(String cityCode){
		HashMap<City, City> matchingCity=new HashMap<City, City>();
		
		for(Entry<City, City> city:cityMap.entrySet()){
			if(city.getKey().getCityCode().contains(cityCode.toUpperCase())){
				matchingCity.put(city.getKey(), city.getValue());
			}
		}
		
		return matchingCity;
	}
}
