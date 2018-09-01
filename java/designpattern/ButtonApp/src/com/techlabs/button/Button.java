package com.techlabs.button;

import java.util.ArrayList;

public class Button implements ButtonObserverable{
	private ArrayList<ActionObserver> observerList=new ArrayList<ActionObserver>();
	private String buttonName;
	private int height;
	private int width;
	private String action;
	private boolean isPressed=false;
	
	public Button(String name,int height,int width){
		this.buttonName=name;
		this.height=height;
		this.width=width;
	}
	
	public void press(){
		if(isPressed){
			action="Delete....";
			isPressed=false;
		}
		else{
			action="Add....";
			isPressed=true;
		}

		notifyAction();
	}
	
	public Integer getHeight(){
		return this.height;
	}
	
	public Integer getWidth(){
		return this.width;
	}
	
	public String getName(){
		return this.buttonName;
	}
	
	@Override
	public void register(ActionObserver o) {
		observerList.add(o);
	}

	@Override
	public void remove(ActionObserver o) {
		observerList.remove(o);
	}
	
	@Override
	public void notifyAction() {
		for(ActionObserver observer:observerList){
			observer.update(action);
		}
	}
}
