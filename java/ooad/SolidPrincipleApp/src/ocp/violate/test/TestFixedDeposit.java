package ocp.violate.test;

import ocp.violate.FestivalType;
import ocp.violate.FixedDeposit;

public class TestFixedDeposit {
	public static void main(String[] args) {
		FixedDeposit fixedDeposit=new FixedDeposit("Chandan", 5000.0, 5, FestivalType.DIWALI);
		
		System.out.println("InterestAmount: "+fixedDeposit.calculateTotalInterest());
	}
}
