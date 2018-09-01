package com.techlabs.human;

import java.io.Serializable;

public class Human implements Serializable {

	private String name;
	private int age;
	private float height=5.0f;
	private float weight=40.0f;
	private GenderType gender;
	
	public Human(String name,int age,float height,float weight,GenderType gender){
		this(name,gender,age);
		this.height=height;
		this.weight=weight;
	}
	
	public Human(String name,GenderType gender,int age){
		this.name=name;
		this.gender=gender;
		this.age=age;
	}
	
	public String getName(){
		return this.name;
	}
	
	public int getAge(){
		return this.age;
	}
	
	public float getHeight(){
		return this.height;
	}
	
	public float getWeight(){
		return this.weight;
	}
	
	public GenderType getGender(){
		return this.gender;
	}
	
	public void eat(){
		this.weight+=1.9f;
	}
	
	public void workout(){
		this.height+=0.1f;
		this.weight-=0.9f;
	}
	
	private float calculateBMI(){
		float hei=(this.height*0.3048f);
		float wei=this.weight;
		float bmi;
		bmi=wei/(hei*hei);
		
		return bmi;
	}
	
	public String healthRecommendation(){
		float result=calculateBMI();
		System.out.println("Your BMI is "+result);
		
		if(result<18.5f){
			return "UNDERWEIGHT";	
		}
		else if(result>24.0f){
			return "OVERWEIGHT";	
		}
		
		return "NORMAL";
	}
}
