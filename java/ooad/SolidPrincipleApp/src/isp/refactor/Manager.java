package isp.refactor;

public class Manager implements Workable{

	@Override
	public void startEat() {
		System.out.println("Manager start eating.");
	}

	@Override
	public void stopEat() {
		System.out.println("Manager Stops Eating.");
	}

	@Override
	public void startWork() {
		System.out.println("Manager Starts Working.");
	}

	@Override
	public void stopWork() {
		System.out.println("Manager Stops working");
		
	}
}
