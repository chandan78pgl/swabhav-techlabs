package isp.refactor.test;

import isp.refactor.Eat;
import isp.refactor.Manager;
import isp.refactor.Robot;
import isp.refactor.Work;

public class TestRefactorWorker {
	public static void main(String[] args) {
		
		atTheWorkStation(new Manager());
		atTheWorkStation(new Robot());
		
		atTheCafetarea(new Manager());
	}
	
	public static void atTheWorkStation(Work worker){
		System.out.println("At the Work Station.");
		worker.startWork();
		worker.stopWork();
	}
	
	public static void atTheCafetarea(Eat worker){
		System.out.println("At the Cafetarea.");
		worker.startEat();
		worker.stopEat();
	}
}
