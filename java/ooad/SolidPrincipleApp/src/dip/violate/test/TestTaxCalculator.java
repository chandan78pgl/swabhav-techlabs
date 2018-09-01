package dip.violate.test;

import dip.violate.LogType;
import dip.violate.TaxCalculator;

public class TestTaxCalculator {
	public static void main(String[] args) {
		TaxCalculator taxCalculator=new TaxCalculator(LogType.TXT);
		System.out.println(taxCalculator.calculateTax(2000, -1));
	}
}
