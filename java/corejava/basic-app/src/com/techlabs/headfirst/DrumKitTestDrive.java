package com.techlabs.headfirst;

public class DrumKitTestDrive {
	public static void main(String[] args){
		DrumKit d = new DrumKit();
		
		d.playsnare();
		d.snare=false;
		d.playTopHat();
		
		if(d.snare==true){
			d.playsnare();
		}
	}
}

class DrumKit{
	
	boolean topHat=true;
	boolean snare=true;
	
	void playsnare(){
		System.out.println("bang bang ba-bang");
	}
	
	void playTopHat(){
		System.out.println("ding ding da-ding");
	}
}
