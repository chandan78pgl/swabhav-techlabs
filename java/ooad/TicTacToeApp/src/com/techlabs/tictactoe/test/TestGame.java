package com.techlabs.tictactoe.test;

import static org.junit.Assert.*;

import java.io.BufferedReader;
import java.io.InputStreamReader;

import org.junit.Test;

import com.techlabs.tictactoe.Board;
import com.techlabs.tictactoe.Game;
import com.techlabs.tictactoe.MarkType;
import com.techlabs.tictactoe.Player;
import com.techlabs.tictactoe.ResultAnalyzer;

public class TestGame {

	@Test
	public void testWinCase() {
		Player player1=new Player("Chandan", MarkType.CROSS);
		Player player2=new Player("Dharmesh", MarkType.NOUGHT);
		Board board=new Board();
		ResultAnalyzer resultAnalyzer=new ResultAnalyzer(board);
		Game game=new Game(player1,player2, board, resultAnalyzer);
		game.initializeGame();
		
		game.play(1);
		game.play(4);
		game.play(2);
		game.play(5);
		game.play(8);
		game.play(6);
		System.out.println(game.getResultAnalyzer().getResult());
		game.displayGame();
		
	}
	@Test
	public void testDrawCase() {
		Player player1=new Player("Chandan", MarkType.CROSS);
		Player player2=new Player("Dharmesh", MarkType.NOUGHT);
		Board board=new Board();
		ResultAnalyzer resultAnalyzer=new ResultAnalyzer(board);
		Game game=new Game(player1,player2, board, resultAnalyzer);
		game.initializeGame();
		
		game.play(1);
		game.play(2);
		game.play(3);
		game.play(4);
		game.play(5);
		game.play(9);
		game.play(8);
		game.play(7);
		game.play(6);

		System.out.println(game.getResultAnalyzer().getResult());
		game.displayGame();
		
	}
	
	@Test
	public void testValidChoiceCase() {
		System.out.println("\n--------ValidChoice Case");
		Player player1=new Player("Chandan", MarkType.CROSS);
		Player player2=new Player("Dharmesh", MarkType.NOUGHT);
		Board board=new Board();
		ResultAnalyzer resultAnalyzer=new ResultAnalyzer(board);
		Game game=new Game(player1,player2, board, resultAnalyzer);
		game.initializeGame();
		
		game.play(1);
		game.play(4);
		game.play(4);
		game.play(2);
		game.play(6);
		
		game.displayGame();
		
	}
}
