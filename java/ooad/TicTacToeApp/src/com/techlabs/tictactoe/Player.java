package com.techlabs.tictactoe;

public class Player {
	private String name;
	private MarkType mark;
	
	public Player(String name,MarkType mark){
		this.name=name;
		this.mark=mark;
	}
	
	public String getName(){
		return this.name;
	}
	
	public MarkType getMark(){
		return this.mark;
	}
	
	@Override
	public String toString(){ 
		return this.name+" -> "+this.mark.toString();
	}
}
