package com.techlabs.dougdoor;

import java.util.ArrayList;
import java.util.Timer;
import java.util.TimerTask;

public class DogDoor {
	private boolean open;
	private ArrayList<Bark> allowedBarks=new ArrayList<Bark>();
	
	public DogDoor(){
		this.open=false;
	}
	
	public void addAllowedBark(Bark bark){
		allowedBarks.add(bark);
	}
	
	public ArrayList<Bark> getAllowedBarks(){
		return this.allowedBarks;
	}
	
	public void open(){
		System.out.println("The Dog door opens.");
		final Timer timer= new Timer();
		timer.schedule(new TimerTask() {
			
			@Override
			public void run() {
				close();
				timer.cancel();
			}
		},5000);
		this.open=true;
	}
	
	public void close(){
		System.out.println("The Dog Door closes.");
		this.open=false;
	}
	
	public boolean isOpen(){
		return this.open;
	}
}
