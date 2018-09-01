

public class TestAnimal {
	public static void main(String[] args){
		Animal animal=new Dog();
		
		animal.foo();
		//animal.bar();
		animal.show();
		//animal.tar();
	}
}

abstract class Animal{
	public abstract void show();
	
	public abstract void foo();
}

abstract class Canine extends Animal{
	public abstract void bar();
	public abstract void tar();
}

class Dog extends Canine{
	public void show(){
		System.out.println("This is the class calls everything");
	}
	
	public void foo(){
		System.out.println("This is the foo method");
	}
	
	public void bar(){
		System.out.println("This is the bar method just called");
	}
	
	public void tar(){
		System.out.println("This is the tar method just called");
	}
}

