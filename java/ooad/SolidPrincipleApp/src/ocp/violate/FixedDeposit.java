package ocp.violate;

public class FixedDeposit {
	private String accountHolder;
	private double principle;
	private int duration;
	private FestivalType festivalType;
	
	public FixedDeposit(String accountHolder, double principle,int duration,FestivalType festivalType){
		this.accountHolder=accountHolder;
		this.principle=principle;
		this.duration=duration;
		this.festivalType=festivalType;
	}
	
	public Double calculateTotalInterest(){
		
		if (festivalType==FestivalType.DIWALI) {
			return this.principle*this.duration*0.08; 
		}
		if (festivalType==FestivalType.HOLI) {
			return this.principle*this.duration*0.075; 
		}
		if (festivalType==FestivalType.RAMZAN) {
			return this.principle*this.duration*0.07; 
		}
		if (festivalType==FestivalType.NORMAL) {
			return this.principle*this.duration*0.06; 
		}
		
		return null;
	}
}
