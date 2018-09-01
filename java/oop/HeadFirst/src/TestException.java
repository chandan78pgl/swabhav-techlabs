
class CustomException extends Exception{
	
	private String s;
	public CustomException(String s){
		super(s);
		this.s=s;
	}
	
	public String getMessage(){
		return this.s;
	}
}

public class TestException{
	public static void main(String[] args){
		try{
			if(validateAge()<18){
				throw new CustomException("this is the custom exception age must be above 18");
			}
			else{
				System.out.println("Everything is fine");
			}
				
		}
		catch(CustomException e){
			System.out.println(e.getMessage());
		}
	}
	
	public static int validateAge(){
		return 12;
	}
}
