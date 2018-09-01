package com.techlabs.guitar.test;

import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import com.techlabs.guitar.Builder;

import com.techlabs.guitar.Instrument;
import com.techlabs.guitar.InstrumentSpec;
import com.techlabs.guitar.InstrumentType;
import com.techlabs.guitar.Inventory;
import com.techlabs.guitar.Style;
import com.techlabs.guitar.Type;
import com.techlabs.guitar.Wood;

public class FindGuitarTester {

	public static void main(String[] args) {
		Inventory inventory = new Inventory();
		initializeInventory(inventory);
		
		Map<String, Object> properties=new HashMap<String, Object>();
		properties.put("builder", Builder.COLLINGS);
		properties.put("backWood", Wood.SITKA);
		InstrumentSpec clientSpec=new InstrumentSpec(properties);
				
		List<Instrument> matchingInstruments=inventory.search(clientSpec);
		if(!matchingInstruments.isEmpty()){
			System.out.println("You might like these Instruments: ");
			for(Iterator<Instrument> i=matchingInstruments.iterator();i.hasNext();){
				Instrument instrument=(Instrument)i.next();
				InstrumentSpec spec=instrument.getSpec();
				
				System.out.println("We have a "+spec.getProperty("instrumentType")+" with the following Properties.");
				for(Iterator<String> j=spec.getProperties().keySet().iterator();j.hasNext();){
					String propertyName=(String)j.next();
					if(propertyName.equals("instrumentType")){
						continue;
					}
					System.out.println("    "+propertyName+": "+spec.getProperty(propertyName));
				}
				System.out.println("  You can have this "+spec.getProperty("instrumentType")+" for $"+instrument.getPrice()+"\n---------------");
			}
		}
		else{
			System.out.println("Sorry, Erin, We have nothing for You.");
		}
	}
	
	public static void initializeInventory(Inventory inventory){
		Map<String, Object> properties=new HashMap<String,Object>();
		
		properties.put("instrumentType", InstrumentType.GUITAR);
		properties.put("builder", Builder.COLLINGS);
		properties.put("model", "CJ");
		properties.put("type", Type.ACOUSTIC);
		properties.put("numStrings", 6);
		properties.put("topWood", Wood.INDIAN_ROSEWOOD);
		properties.put("backWood", Wood.SITKA);
		
		inventory.addInstrument("11127", 3999.95, new InstrumentSpec(properties));		
	}
}
