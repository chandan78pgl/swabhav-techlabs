package srp.refactor.test;

import srp.refactor.Invoice;
import srp.refactor.PrintInvoice;

public class TestRefectorInvoice {
	public static void main(String[] args) {
		Invoice invoice=new Invoice(101, "Shoes ", 2999.0, 10, 18, "20/08/2018");
		PrintInvoice printInvoice=new PrintInvoice(invoice);
		printInvoice.printInvoice();
	}
}