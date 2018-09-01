package com.techlabs.calculator.test;

import static org.junit.Assert.*;

import org.junit.Test;

import com.techlabs.calculator.Calculator;

public class TestCalculator {

	@Test
	public void test() {
		Calculator calculator=new Calculator();
		int answer=calculator.addEvenNumber(2, 4);
		assertEquals(6, answer);
	}
	
	@Test
	public void test2() {
		Calculator calculator=new Calculator();
		double answer=calculator.cubeOddNumber(3);
		assertEquals(27.0, answer,0);
	}
	

}
