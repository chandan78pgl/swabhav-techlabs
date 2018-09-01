package com.techlabs.dougdoor.test;

import com.techlabs.dougdoor.Bark;
import com.techlabs.dougdoor.BarkRecognizer;
import com.techlabs.dougdoor.DogDoor;
import com.techlabs.dougdoor.Remote;

public class TestDogDoor {
	@SuppressWarnings("static-access")
	public static void main(String[] args) {
		DogDoor door=new DogDoor();
		
		door.addAllowedBark(new Bark("rowlf"));
		door.addAllowedBark(new Bark("rooowlf"));
		door.addAllowedBark(new Bark("rawlf"));
		door.addAllowedBark(new Bark("woof"));
		
		BarkRecognizer recognizer=new BarkRecognizer(door);
		Remote remote=new Remote(door);
		
		System.out.println("Bruce starts Barking.");
		recognizer.recognize(new Bark("rowlf"));
		//remote.pressButton();
		
		System.out.println("\n Bruce has gone outside.");
		
		try {
			Thread.currentThread().sleep(10000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println("\n Bruce's all done.");
		
		System.out.println("......but he's stuck outside.");
		
		Bark smallDogBark=new Bark("Yip");
		System.out.println("A Small Dog Starts barking");
		
		recognizer.recognize(smallDogBark);
		
		try {
			Thread.currentThread().sleep(5000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		System.out.println("Bruce Starts Barking..");
		recognizer.recognize(new Bark("rooowlf"));
		//System.out.println("Gina grabs the remote control.");
		
		//remote.pressButton();
		System.out.println("\n Bruce's Back inside.");
	}
}
