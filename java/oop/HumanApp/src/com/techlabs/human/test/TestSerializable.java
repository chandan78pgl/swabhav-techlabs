package com.techlabs.human.test;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;

import com.techlabs.human.GenderType;
import com.techlabs.human.Human;

public class TestSerializable {
	public static void main(String[] args) throws IOException,FileNotFoundException{
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
		
		FileOutputStream fo=new FileOutputStream("newfile1.ser");
		ObjectOutputStream oo=new ObjectOutputStream(fo);
		
		oo.writeObject(human1);
		oo.writeObject(human2);
		
		oo.close();
		fo.close();
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
