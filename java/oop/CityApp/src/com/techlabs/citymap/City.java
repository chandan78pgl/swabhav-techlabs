package com.techlabs.citymap;

public class City {
	private String cityCode;
	private String cityDescription;
	
	public City(String cityCode,String cityDescription){
		this.cityCode=cityCode;
		this.cityDescription=cityDescription;
	}
	
	public String getCityCode(){
		return this.cityCode;
	}
	
	public String getCityDescription(){
		return this.cityDescription;
	}
	
	@Override
	public String toString() {
		String string="CityCode: "+this.cityCode
				+"\nDescription: "+this.cityDescription;
		
		return string;
	}
}
