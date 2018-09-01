package dip.refactor.test;

import dip.refactor.DBLogger;
import dip.refactor.TaxCalculator;
import dip.refactor.TxtLogger;

public class TestTaxCalculator {
	public static void main(String[] args) {
		TaxCalculator taxCalculator=new TaxCalculator(new DBLogger());
		System.out.println(taxCalculator.calculateTax(2000, 0));
	}
}
