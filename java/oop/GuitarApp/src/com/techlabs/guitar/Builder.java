package com.techlabs.guitar;

public enum Builder {

	FENDER,MARTIN,GIBSON,COLLINGS,OLSON,RYAN,PRS,ANY;
	
	public String toString(){
		switch(this){
		case FENDER: return "Fender";
		case MARTIN: return "Martin";
		case GIBSON: return "Gibson";
		case OLSON: return "Olson";
		case RYAN: return "Ryan";
		case ANY: return "any";
		case COLLINGS: return "Collings";
		case PRS: return "Prs";
		}
		return null;
	}
}
