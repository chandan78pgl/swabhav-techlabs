package dip.violate;

public class TaxCalculator {
	private LogType logType;
	
	public TaxCalculator(LogType logType){
		this.logType=logType;
	}
	
	public int calculateTax(int salary,int GSTrate){
		int amount=0;
		try{
			amount=salary/GSTrate;
			if(amount<0){
				throw new Exception("Input Problem");
			}
			
		}
		catch(NumberFormatException e){
			if(this.logType==LogType.TXT){
				TxtLogger txtLogger=new TxtLogger();
				
				txtLogger.log(e);
			}
			if(this.logType==LogType.DB){
				DBLogger dbLogger=new DBLogger();
				dbLogger.log(e);
			}
			if(this.logType==LogType.EMAIL){
				EmailLogger emailLogger=new EmailLogger();
				emailLogger.log(e);
			}
			
		}
		catch(Exception e){
			if(this.logType==LogType.TXT){
				TxtLogger txtLogger=new TxtLogger();
				txtLogger.log(e);
			}
			if(this.logType==LogType.DB){
				DBLogger dbLogger=new DBLogger();
				dbLogger.log(e);
			}
			if(this.logType==LogType.EMAIL){
				EmailLogger emailLogger=new EmailLogger();
				emailLogger.log(e);
			}
			amount=-1;
		}
		
		return amount;
	}
}
