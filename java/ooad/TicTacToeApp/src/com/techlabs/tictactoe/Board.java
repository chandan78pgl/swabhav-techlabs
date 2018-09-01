package com.techlabs.tictactoe;

import java.util.ArrayList;
import java.util.List;

public class Board {
	private ArrayList<Cell> cells=new ArrayList<Cell>();
	
	public Board(){
		initializeBoard();
	}
	
	private void initializeBoard(){
		for(int i=0;i<9;i++)
			this.cells.add(new Cell());
	}
	
	public List<Cell> getCells(){
		return this.cells;
	}
	
	public Cell getCell(int position){
		return this.cells.get(position);
	}
	
	public void displayBoard(){
		System.out.println("-----------------------------------------------\n "+this.cells.get(0)+" | "+this.cells.get(1)+" | "+this.cells.get(2)
				+"\n--- --- ---"
				+"\n "+this.cells.get(3)+" | "+this.cells.get(4)+" | "+this.cells.get(5)
				+"\n--- --- ---"
				+"\n "+this.cells.get(6)+" | "+this.cells.get(7)+" | "+this.cells.get(8));
	}
	
	public void updateBoard(MarkType mark,Integer position){
		this.cells.get(position-1).setCell(mark);
	}
	
	public boolean isBoardFilled(){
		for(Cell cell:this.cells){
			if(cell.getMark().toString().equals("E"))
				return false;
		}
		return true;
	}
	
	public Cell[][] generateBoardMatrix(){
		Cell[][] mCells=new Cell[3][3];
		
		int k=0;
		for(int i=0;i<3;i++){
			for(int j=0;j<3;j++){
				mCells[i][j]=this.cells.get(k);
				k++;
			}
		}
		return mCells;
	}
}
