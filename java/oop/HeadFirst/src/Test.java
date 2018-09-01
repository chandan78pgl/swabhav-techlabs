
class TestInterface implements Foo {

	@Override
	public void read() {
		System.out.println("Read is Calling...");
		
	}

	@Override
	public void wish() {
		System.out.println("Wish is Calling...");
		
	}

	@Override
	public void play() {
		System.out.println("Play is Calling...");
		
	}
}

public class Test{
	public static void main(String[] args) {
		TestInterface testInterfaces=new TestInterface();
		
		testInterfaces.read();
		testInterfaces.play();
		testInterfaces.wish();
		
	}
}
