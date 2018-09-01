package com.techlabs.dataanalyzer.test;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.HashSet;

import org.junit.Test;

import com.techlabs.dataanalyzer.DataParser;
import com.techlabs.dataanalyzer.Employee;
import com.techlabs.dataanalyzer.FileLoader;

public class testDataParser {

	@Test
	public void test() throws FileNotFoundException, IOException {
		HashSet<Employee> dataList=null;
		DataParser dataparser=new DataParser(new FileLoader());
		dataList=(HashSet<Employee>) dataparser.parseData();
		System.out.println(dataList);
	}

}
