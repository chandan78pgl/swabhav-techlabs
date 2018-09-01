package com.techlabs.gameui;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import com.techlabs.tictactoe.Board;
import com.techlabs.tictactoe.Game;
import com.techlabs.tictactoe.Player;
import com.techlabs.tictactoe.ResultAnalyzer;

public class StartButtonHandler implements ActionListener{
	private PlayerFrame frame;
	private Player[] players;
	private GameUIConsole gameuiconsole;
	private Game game;
	
	public StartButtonHandler(PlayerFrame frame) {
		this.frame=frame;
	}
	
	@Override
	public void actionPerformed(ActionEvent arg0) {
		this.frame.setPlayers();
		players=this.frame.getPlayers();
		frame.display();
		gameuiconsole=new GameUIConsole(players);
	}

}
