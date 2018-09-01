package isp.violate;

public class Robot implements Worker {

	@Override
	public void startEat() {
		throw new RuntimeException("Violating ISP");
	}

	@Override
	public void stopEat() {
		throw new RuntimeException("Solve through ISP decouple interfaces");
	}

	@Override
	public void startWork() {
		System.out.println("Robot Starts Working.");
		
	}

	@Override
	public void stopWork() {
		System.out.println("Robot Stops Working.");
		
	}

}
