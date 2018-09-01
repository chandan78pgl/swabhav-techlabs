package ocp.refactor;

public class FixedDeposit {
	private String accountHolder;
	private double principle;
	private int duration;
	private Festival festival;
	
	public FixedDeposit(String accountHolder, double principle,int duration,Festival festival){
		this.accountHolder=accountHolder;
		this.principle=principle;
		this.duration=duration;
		this.festival=festival;
	}
	
	public String getAccountHolderName(){
		return this.accountHolder;
	}
	
	public Double getPrinciple(){
		return this.principle;
	}
	
	public int getDuration(){
		return this.duration;
	}
	
	public Festival getFestival(){
		return this.festival;
	}
	
	public Double calculateTotalInterest(){
		if(this.festival!=null)
			return this.principle*this.duration*festival.getRate();
		return this.principle*this.duration*0.06;
	}
}
