package com.techlabs.guitar;

import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

public class InstrumentSpec {
	private Map<String,Object> properties;
	
	public InstrumentSpec(Map<String, Object> properties){
		if(properties==null)
			this.properties=new HashMap<String, Object>();
		else
			this.properties=new HashMap<String, Object>(properties);
	}
	
	public Object getProperty(String propertyName){
		return this.properties.get(propertyName);
	}
	
	public Map<String, Object> getProperties(){
		return this.properties;
	}
	
	public boolean matches(InstrumentSpec otherSpec){
		for(Iterator<String> property=otherSpec.getProperties().keySet().iterator();property.hasNext();){
			String propertyName=(String)property.next();
			if(!this.properties.get(propertyName).equals(otherSpec.getProperty(propertyName))){
				return false;
			}
		}
		return true;
	}

}
