package com.techlabs.dataanalyzer;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class FileLoader implements Loader  {
	private ArrayList<String> empArray = new ArrayList<String>();
	
	public List<String> loadData() throws IOException {
		
		FileReader fr=new FileReader("resource/empdata.txt");
		BufferedReader br=new BufferedReader(fr);
		String string="";
		
		while((string=br.readLine())!=null){
			empArray.add(string);
		}
		br.close();
		fr.close();
		
		return empArray;
	}
}
