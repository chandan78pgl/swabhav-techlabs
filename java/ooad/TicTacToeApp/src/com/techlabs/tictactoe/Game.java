package com.techlabs.tictactoe;

public class Game {
	private Player player1;
	private Player player2;
	private Board board;
	private ResultAnalyzer resultAnalyzer;
	private Player currentPlayer;
	private boolean turn = true;
	private boolean winner = false;

	public Game(Player player1, Player player2, Board board,
			ResultAnalyzer resultAnalyzer) {
		this.player1 = player1;
		this.player2 = player2;
		this.board = board;
		this.resultAnalyzer = resultAnalyzer;
		this.currentPlayer=player1;
	}

	public void initializeGame() {
		this.board.displayBoard();
	}

	public void play(int position) {
		if (validChoice(position)) {
			this.currentPlayer=getTurn();
			this.board.updateBoard(this.getCurrentPlayer().getMark(), position);

			this.resultAnalyzer.analyzeBoard();

			if (turn) {
				this.turn = false;
			} else {
				this.turn = true;
			}
		}else{
			System.out.println("Choose a valid Option: "+this.getTurn());
		}
	}
	
	public Player getCurrentPlayer(){
		return this.currentPlayer;
	}
	public Board getBoard(){
		return this.board;
	}

	public boolean validChoice(int position) {
		if (!this.board.getCell(position-1).isMarked())
			return true;
		return false;
	}

	public Player getTurn() {
		if (turn) {
			return this.player1;
		} else {
			return this.player2;
		}
	}

	public void displayGame() {
		if (!this.winner)
			this.board.displayBoard();
	}

	public ResultAnalyzer getResultAnalyzer() {
		return this.resultAnalyzer;
	}
}
