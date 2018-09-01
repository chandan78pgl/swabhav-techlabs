package com.techlabs.dougdoor;

public class Bark {
	private String sound;
	
	public Bark(String sound){
		this.sound=sound;
	}
	
	public String getSound(){
		return this.sound;
	}
	
	public boolean equals(Object obj){
		Bark bark=(Bark)obj;
		
		if(this.sound==bark.getSound()){
			return true;
		}
		return false;
	}
}