package com.techlabs.tictactoe;

public enum MarkType {
	NOUGHT,CROSS,EMPTY;
	
	public String toString() {
		switch(this){
		case NOUGHT: return "O";
		case CROSS: return "X";
		case EMPTY: return "E";
		default: return "UNSPECIFIED";
		}
	}
}
