package dip.refactor;

public class EmailLogger implements Logger {
	
	@Override
	public void log(Exception e){
		System.out.println("Exception logged to Email: "+e);
	}
}
