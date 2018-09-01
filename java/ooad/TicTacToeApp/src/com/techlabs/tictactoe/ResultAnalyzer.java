package com.techlabs.tictactoe;

public class ResultAnalyzer {
	private Board board;
	private Result result;
	private Cell[][] boardCells;
	
	public ResultAnalyzer(Board board){
		this.board=board;
		this.boardCells=board.generateBoardMatrix();
		this.result=Result.ONGOING;
	}
	
	public void analyzeBoard(){
		
		for(int i=0;i<this.board.getCells().size();i++){
			if(this.board.getCell(i).isMarked()){
				checkWin(i+1);
			}
		}
		
		if(board.isBoardFilled() && this.result!=Result.WIN){
			this.result=Result.DRAW;	
		}
	}

	private void checkWin(int position) {
		switch(position){
		case 1: if(checkVertical(0) || checkHorizontal(0) || checkDiagonal()){ 
					this.result=Result.WIN;
				}
				break;
			
		case 3: if(checkVertical(2) || checkHorizontal(0) || checkDiagonal()){ 
					this.result=Result.WIN;
				}
				break;
			
		case 5:	if(checkVertical(1) || checkHorizontal(1) || checkDiagonal()){ 
					this.result=Result.WIN;
				}
				break;
			
		case 7: if(checkVertical(0) || checkHorizontal(2) || checkDiagonal()){ 
					this.result=Result.WIN;
				}
				break;
		case 9: if(checkVertical(2) || checkHorizontal(2) || checkDiagonal()){ 
					this.result=Result.WIN;
				}
				break;	
		
		case 2:	if(checkVertical(1) || checkHorizontal(0)){ 
					this.result=Result.WIN; 
				}
				break;
		
		case 4: if(checkVertical(0) || checkHorizontal(1)){ 
					this.result=Result.WIN;
				}
				break;
		
		case 6: if(checkVertical(2) || checkHorizontal(1)){ 
					this.result=Result.WIN;
				}
				break;
		
		case 8: if(checkVertical(1) || checkHorizontal(2)){ 
					this.result=Result.WIN; 
				}
				break;
		}
	}
	
	private boolean checkVertical(int col){
		if(boardCells[0][col].getMark().equals(boardCells[1][col].getMark()))
			if( boardCells[0][col].getMark().equals(boardCells[2][col].getMark()))
				if(!(boardCells[0][col].getMark().equals("E")))
					return true;
		return false;
	}
	
	private boolean checkHorizontal(int row){
		if(boardCells[row][0].getMark().equals(boardCells[row][1].getMark()))
			if( boardCells[row][0].getMark().equals(boardCells[row][2].getMark()))
				if(!(boardCells[row][0].getMark().equals("E")))
					return true;
		return false;
	}
	
	private boolean checkDiagonal(){
		if(boardCells[0][0].getMark().equals(boardCells[1][1].getMark()))
			if( boardCells[0][0].getMark().equals(boardCells[2][2].getMark()))
				if(!(boardCells[0][0].getMark().equals("E")))
					return true;
		
		if(boardCells[0][2].getMark().equals(boardCells[1][1].getMark()))
			if( boardCells[0][2].getMark().equals(boardCells[2][0].getMark()))
				if(!(boardCells[0][2].getMark().equals("E")))
					return true;
		
		return false;
	}
	
	public String getResult(){
		return this.result.toString();
	}
}
