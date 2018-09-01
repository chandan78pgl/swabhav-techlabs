package lsp.violate;

public class Rectangle {
	protected int height;
	protected int width;
	
	public Rectangle(int height,int width){
		this.height=height;
		this.width=width;
	}
	
	public void setWidth(int width){
		this.width=width;
	}
	
	public void setHeight(int height){
		this.height=height;
	}
	
	public int getHeight(){
		return this.height;
	}
	
	public int getWidth(){
		return this.width;
	}
	
	public int area(){
		return this.height*this.width;
	}
}
