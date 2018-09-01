package isp.refactor;

public class Robot implements Work {

	@Override
	public void startWork() {
		System.out.println("Robot Starts Working.");
	}

	@Override
	public void stopWork() {
		System.out.println("Robot Stops Working.");
	}
}
