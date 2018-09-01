package com.techlabs.tictactoe;

public class Cell {
	private MarkType mark;
	
	public Cell(){
		this.mark=MarkType.EMPTY;
	}
	
	public void setCell(MarkType mark){
		if(!isMarked()){
			this.mark=mark;
		}else{
			System.out.println("Already Marked.");
		}
	}
	
	public String getMark(){
		return this.mark.toString();
	}
	
	public boolean isMarked(){
		if(!this.mark.equals(MarkType.EMPTY))
			return true;
		return false;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return this.mark.toString();
	}
}