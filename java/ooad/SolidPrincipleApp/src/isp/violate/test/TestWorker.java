package isp.violate.test;

import isp.violate.Manager;
import isp.violate.Robot;
import isp.violate.Worker;

public class TestWorker {
	public static void main(String[] args) {
	
		atTheWorkStation(new Manager());
		atTheWorkStation(new Robot());
		
		atTheCafetarea(new Manager());
		atTheCafetarea(new Robot());
	}
	
	public static void atTheWorkStation(Worker worker){
		System.out.println("At the Work Station.");
		worker.startWork();
		worker.stopWork();
	}
	
	public static void atTheCafetarea(Worker worker){
		System.out.println("At the Cafetarea.");
		worker.startEat();
		worker.stopEat();
	}
}
