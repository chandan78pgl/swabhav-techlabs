package com.techlabs.human.test;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.ObjectInputStream;

import com.techlabs.human.Human;

public class TestDeserializable {
	public static void main(String[] args) throws FileNotFoundException,IOException, ClassNotFoundException{
		
		FileInputStream fi=new FileInputStream("newfile1.ser");
		ObjectInputStream oi=new ObjectInputStream(fi);
		
		Human human1=(Human) oi.readObject();
		Human human2=(Human) oi.readObject();
		
		printDetails(human1);
		printDetails(human2);
		
		oi.close();
		fi.close();
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
