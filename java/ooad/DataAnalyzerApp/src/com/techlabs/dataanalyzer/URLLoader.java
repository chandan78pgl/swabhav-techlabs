package com.techlabs.dataanalyzer;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;

public class URLLoader implements Loader {
	private ArrayList<String> empArray = new ArrayList<String>();

	@Override
	public List<String> loadData() throws IOException {
		URL url=new URL("https://swabhav-tech.firebaseapp.com/emp.txt");
		BufferedReader br=new BufferedReader(new InputStreamReader(url.openStream()));
		String string="";
		
		while((string=br.readLine())!=null){
			empArray.add(string);
		}
		br.close();
		return empArray;
	}

}
