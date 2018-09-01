package srp.refactor;

public class PrintInvoice {
	private Invoice invoice;
	
	public PrintInvoice(Invoice invoice){
		this.invoice=invoice;
	}
	
	public void printInvoice(){
		System.out.println(invoice);
	}
}