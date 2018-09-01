package com.techlabs.dougdoor;

import java.util.Iterator;
import java.util.List;

public class BarkRecognizer {
	private DogDoor door;
	
	public BarkRecognizer(DogDoor door){
		this.door=door;
	}
	
	public void recognize(Bark bark){
		System.out.println("Bark Recognize: Heard a '"+bark.getSound()+"'");
		
		List<Bark> allowedBarks=door.getAllowedBarks();
		
		for(Iterator<Bark> iterbark=allowedBarks.iterator();iterbark.hasNext();){
			Bark allowedBark=(Bark)iterbark.next();
			if(allowedBark.equals(bark)){
				door.open();
				return;
			}
		}
		System.out.println("This dog is not allowed.");
	}
}
