package com.techlabs.guitar;

public enum Wood {
	INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, MAPLE,
	COCOBOLO,CEDAR,ADIRONDACK,ALDER,SITKA;
	
	public String toString(){
		switch(this){
		case INDIAN_ROSEWOOD: return "Indian Rosewood";
		case BRAZILIAN_ROSEWOOD: return "Brazilian Rosewood";
		case ADIRONDACK: return "Adirondack";
		case ALDER: return "Alder";
		case CEDAR: return "Cedar";
		case COCOBOLO: return "Cocobolo";
		case MAHOGANY: return "Mahogany";
		case MAPLE: return "Maple";
		case SITKA: return "Sitka";
		}
		
		return null;
	}
}
