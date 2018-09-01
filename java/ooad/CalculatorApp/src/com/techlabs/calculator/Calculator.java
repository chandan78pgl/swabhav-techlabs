package com.techlabs.calculator;

public class Calculator {
	public int addEvenNumber(int a,int b){
		if(a%2==0 && b%2==0)
			return a+b;
		return 0;
	}
	
	public Double cubeOddNumber(double a){
		if(a%2==0)
			return 0.0;
		return (double)a*a*a;
	}
}
