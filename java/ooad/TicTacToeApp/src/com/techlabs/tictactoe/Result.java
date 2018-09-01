package com.techlabs.tictactoe;

public enum Result {
	WIN,ONGOING,DRAW;
	
	public String toString() {
		switch(this){
		case WIN: return "win";
		case ONGOING: return "onGoing";
		case DRAW: return "draw";
		default: return "unspecified";
		}
		
	}
}
