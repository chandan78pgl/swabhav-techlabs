package com.techlabs.account;

public class InsufficientFundException extends Exception {

	/**
	 * 
	 */
	private static final long serialVersionUID = -7784493461754864709L;
	private String string;
	private Account account=null;
	public InsufficientFundException(String string){
		this.string=string;
	}
	
	public InsufficientFundException(Account account,String string){
		this(string);
		this.account=account;
	}
	
	@Override
	public String getMessage(){
		if(this.account!=null)
			return this.string+"\n"+account;
		return this.string;
	}
}
