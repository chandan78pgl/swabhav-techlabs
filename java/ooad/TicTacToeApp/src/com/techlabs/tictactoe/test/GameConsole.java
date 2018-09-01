package com.techlabs.tictactoe.test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import com.techlabs.tictactoe.Board;
import com.techlabs.tictactoe.Game;
import com.techlabs.tictactoe.MarkType;
import com.techlabs.tictactoe.Player;
import com.techlabs.tictactoe.ResultAnalyzer;

public class GameConsole {
	public static void main(String[] args) throws IOException {
		Player player1 = new Player("Chandan", MarkType.CROSS);
		Player player2 = new Player("Dharmesh", MarkType.NOUGHT);
		Board board = new Board();
		ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
		Game game = new Game(player1, player2, board, resultAnalyzer);

		System.out.println("Welcome to Tic Tac Toe.\n 1. Startgame\n  Enter Choice: ");

		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String start = "";
		start = br.readLine();
		System.out.println(start);

		if (start.equals("1")) {
			startGame(game);
		}

		br.close();
	}

	private static void startGame(Game game) throws IOException {
		game.initializeGame();
		String choice = "0";
		while (game.getResultAnalyzer().getResult().equals("onGoing")) {

			System.out.println("Turn:\n Player: " + game.getTurn()
					+ "\nEnter Number: ");
			BufferedReader br = new BufferedReader(new InputStreamReader(
					System.in));
			choice = br.readLine();
			game.play(Integer.parseInt(choice));

			if (game.getResultAnalyzer().getResult() == "win") {
				System.out.println("Winner is " + game.getCurrentPlayer());
			} else if (game.getResultAnalyzer().getResult() == "draw") {
				System.out.println("Game is draw.\nNo one is Winner.");
			}
			game.displayGame();
		}
	}
}
