package com.techlabs.shoppingcart;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class ExportToHtml {
	private static int i=1;
	private static boolean flag=true;
	public static void exportToHtmlFile(String string) throws IOException{
	
		FileWriter fw = new FileWriter(new File("resource/newOrder"+i+".html"));
		BufferedWriter bw = new BufferedWriter(fw);
		
		bw.append("<html><head><title>New Page</title></head><body><pre>");
		
		bw.append(string);
		
		bw.append("</pre></body></html>");
		bw.close();
		i++;
	}
	
	public static void exportAllToHtmlFile(String string) throws IOException{
		
		if(flag){
			FileWriter fw = new FileWriter(new File("resource/newOrder.html"));
			flag=false;
			fw.close();
		}
		FileWriter fw = new FileWriter(new File("resource/newOrder.html"),true);
		
		BufferedWriter bw = new BufferedWriter(fw);
		
		bw.append("<html><head><title>New Page</title></head><body><pre>");
		
		bw.append(string);
		
		bw.append("</pre></body></html>");
		bw.close();
	}
}
