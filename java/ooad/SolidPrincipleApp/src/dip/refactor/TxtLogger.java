package dip.refactor;

public class TxtLogger implements Logger{
	
	@Override
	public void log(Exception e){
		System.out.println("Exception Logged in Txt: "+e);
	}
}
