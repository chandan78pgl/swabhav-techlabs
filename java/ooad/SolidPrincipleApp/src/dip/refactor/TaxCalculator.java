package dip.refactor;

public class TaxCalculator {
	private Logger logger;
	
	public TaxCalculator(Logger logger){
		this.logger=logger;
	}
	
	public int calculateTax(int salary,int GSTrate){
		int amount=0;
		try{
			amount=salary/GSTrate;
			if(amount<0){
				throw new Exception("Input Problem");
			}
			
		}
		catch(Exception e){
			this.logger.log(e);
			amount=-1;
		}
		return amount;
	}
}
