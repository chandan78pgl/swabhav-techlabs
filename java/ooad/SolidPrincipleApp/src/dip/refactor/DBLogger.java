package dip.refactor;

public class DBLogger implements Logger {
	
	@Override
	public void log(Exception e){
		System.out.println("Exception Logged in DB: "+e);
	}
}
