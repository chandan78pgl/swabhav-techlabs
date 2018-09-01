package com.techlabs.tictactoe.test;

import static org.junit.Assert.*;

import org.junit.Test;

import com.techlabs.tictactoe.Board;
import com.techlabs.tictactoe.MarkType;
import com.techlabs.tictactoe.Player;
import com.techlabs.tictactoe.ResultAnalyzer;

public class TestResultAnalyzer {

	@Test
	public void testWinResult() {
		Board board=new Board();
		ResultAnalyzer resultAnalyzer=new ResultAnalyzer(board);
		
		board.updateBoard(MarkType.NOUGHT, 4);
		board.updateBoard(MarkType.CROSS, 1);
		board.updateBoard(MarkType.NOUGHT, 1);
		board.updateBoard(MarkType.NOUGHT, 6);
		board.updateBoard(MarkType.CROSS, 7);
		board.updateBoard(MarkType.NOUGHT, 5);
		board.displayBoard();
		
		resultAnalyzer.analyzeBoard();
		System.out.println(resultAnalyzer.getResult().toString());;
	}
	
	@Test
	public void testDrawResult() {
		Board board=new Board();
		ResultAnalyzer resultAnalyzer=new ResultAnalyzer(board);
		
		board.updateBoard(MarkType.CROSS, 1);
		board.updateBoard(MarkType.NOUGHT, 2);
		board.updateBoard(MarkType.CROSS, 3);
		board.updateBoard(MarkType.NOUGHT, 4);
		board.updateBoard(MarkType.CROSS, 5);
		board.updateBoard(MarkType.NOUGHT, 9);
		board.updateBoard(MarkType.CROSS, 8);
		board.updateBoard(MarkType.NOUGHT, 7);
		board.updateBoard(MarkType.CROSS, 6);
		board.displayBoard();
		
		resultAnalyzer.analyzeBoard();
		System.out.println(resultAnalyzer.getResult().toString());;
	}
	
	@Test
	public void testOnGoingResult() {
		Board board=new Board();
		ResultAnalyzer resultAnalyzer=new ResultAnalyzer(board);
		
		board.updateBoard(MarkType.CROSS, 1);
		board.updateBoard(MarkType.NOUGHT, 2);
		board.updateBoard(MarkType.CROSS, 3);
		board.updateBoard(MarkType.NOUGHT, 4);
		board.updateBoard(MarkType.CROSS, 5);
		board.updateBoard(MarkType.NOUGHT, 6);
		board.displayBoard();
		
		resultAnalyzer.analyzeBoard();
		System.out.println(resultAnalyzer.getResult().toString());;
	}

}
