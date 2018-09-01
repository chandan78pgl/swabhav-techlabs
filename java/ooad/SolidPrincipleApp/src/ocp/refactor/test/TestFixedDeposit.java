package ocp.refactor.test;

import ocp.refactor.Diwali;
import ocp.refactor.FixedDeposit;

public class TestFixedDeposit {
	public static void main(String[] args) {
		FixedDeposit fixedDeposit=new FixedDeposit("Chandan", 5000.0, 5, null);
		
		System.out.println("Interest Amount= "+fixedDeposit.calculateTotalInterest());
	}
}
