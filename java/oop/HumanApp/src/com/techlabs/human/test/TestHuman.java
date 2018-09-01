package com.techlabs.human.test;

import com.techlabs.human.GenderType;
import com.techlabs.human.Human;

public class TestHuman{
	public static void main(String[] args){
		Human human1=new Human("Chandan",22,5.3f,55.0f,GenderType.MALE);
		Human human2=new Human("foo",GenderType.FEMALE,19);
		
		//for human 1
		human1.eat();
		human1.workout();
		human1.workout();
		human1.eat();
		human1.eat();
		
		//for human 2
		human2.eat();
		human2.eat();
		human2.workout();		
		
		printDetails(human1);
		printDetails(human2);
	}
	
	private static void printDetails(Human human){
		System.out.println("Name = "+human.getName()
				+"\nAge = "+human.getAge()
				+"\nGender = "+human.getGender()
				+"\nHeight = "+human.getHeight()
				+"\nWeight = "+human.getWeight()
				+"\nYour Health is "+human.healthRecommendation());
		System.out.println("-----------------------------");
	}
}
