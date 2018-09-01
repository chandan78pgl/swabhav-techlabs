package com.techlabs.guitar;

public enum Style {
	A,F;
	
	public String toString() {
		switch(this){
		case A: return "a";
		case F: return "f";
		}
		return null;
	}
}
