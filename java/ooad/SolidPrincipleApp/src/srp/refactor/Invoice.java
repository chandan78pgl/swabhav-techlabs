package srp.refactor;

public class Invoice {
	private int invoiceId;
	private String description;
	private double cost;
	private float discount;
	private float GST;
	private String date;
	
	public Invoice(int invoiceId,String description,double cost,float discount,float GST,String date){
		this.invoiceId=invoiceId;
		this.description=description;
		this.cost=cost;
		this.discount=discount;
		this.GST=GST;
		this.date=date;
	}
	
	public int getInvoiceNumber(){
		return this.invoiceId;
	}
	
	public String getDescription(){
		return this.description;
	}
	
	public Double getCost(){
		return this.cost;
	}
	
	public Float getDiscount(){
		return this.discount;
	}
	
	public Float getGST_Tax(){
		return this.GST;
	}
	
	public String getDate(){
		return this.date;
	}
	
	private Double calculateDiscount(){
		return (this.cost*this.discount)/100;
	}
	
	private Double calculateTax(){
		return (this.cost*this.GST)/100;
	}
	
	public Double calculateTotal(){
		return this.cost+calculateTax()-calculateDiscount();
	}
	
	@Override
	public String toString() {
		
		return "\nInvoiceDetails:-\n Invoice Number: "+this.invoiceId
				+"\n Description: "+this.description
				+"\n Cost: "+this.cost
				+"\n Discount: "+this.discount+"%"
				+"\n GST Tax: "+this.GST+"%"
				+"\n Date: "+this.date
				+"\n Total: "+calculateTotal();
	}
}