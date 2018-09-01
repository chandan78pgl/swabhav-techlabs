package srp.violate.test;

import srp.violate.Invoice;

public class TestInvoice {
	public static void main(String[] args) {
		Invoice invoice=new Invoice(101, "Shoes ", 2999.0, 10, 18, "20/08/2018");
		invoice.printInvoice();
	}
}
