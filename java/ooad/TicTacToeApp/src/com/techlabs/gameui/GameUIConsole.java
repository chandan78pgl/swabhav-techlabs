package com.techlabs.gameui;

import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import com.techlabs.tictactoe.Board;
import com.techlabs.tictactoe.Game;
import com.techlabs.tictactoe.Player;
import com.techlabs.tictactoe.ResultAnalyzer;

public class GameUIConsole extends JFrame{

	private Player[] players;
	private Board board=new Board();
	private ResultAnalyzer resultAnalyzer=new ResultAnalyzer(board);
	private Game game;
	
	private JPanel headerPanel=new JPanel();
	private JLabel statusLabel = new JLabel("Status: nothing",JLabel.CENTER);
	private JPanel boxPanel = new JPanel();
	private JPanel playerPanel=new JPanel();
	private JLabel currentPlayerLabel;
	private JLabel winPlayer= new JLabel("",JLabel.CENTER);
	
	public GameUIConsole(Player[] players) {
		this.players=players;
		this.game=new Game(players[0], players[1], board, resultAnalyzer);
		this.currentPlayerLabel=new JLabel("Current Player: "+this.game.getTurn().toString());
		
		createFrame();
	}
	
	private void createFrame(){
		this.setLayout(new GridLayout(3,1));
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(400,600);
		
		this.headerPanel.setLayout(new GridLayout(3,1));
		this.boxPanel.setLayout(new GridLayout(3,3));
		this.playerPanel.setLayout(new GridLayout(2,1));
		
		settingUIElements();
		
		this.add(headerPanel);
		this.add(boxPanel);
		this.add(playerPanel);
		display();
	}
	
	private void settingUIElements(){
		JLabel player1Label=new JLabel("Player-1: "+this.players[0].toString(),JLabel.LEFT);
		
		JLabel player2Label=new JLabel("Player-2: "+this.players[1].toString(),JLabel.LEFT);
		
		this.statusLabel.setText("Status: "+resultAnalyzer.getResult());
		
		this.headerPanel.add(player1Label);
		this.headerPanel.add(player2Label);
		this.headerPanel.add(statusLabel);
		
		for(Integer i=0,number=1;i<9;i++,number++){
			JButton button=new JButton(number.toString());
			button.setName(number.toString());
			button.setSize(200,200);
			
			button.addActionListener(new ActionListener() {
				
				@Override
				public void actionPerformed(ActionEvent e) {
					int position = Integer.parseInt(button.getName());
					if(game.validChoice(position) && game.getResultAnalyzer().getResult().equals("onGoing")){
						playGame(position);
						button.setText(game.getCurrentPlayer().getMark().toString());
					}
				}
			});
			
			this.boxPanel.add(button);
		}
		
		this.playerPanel.add(currentPlayerLabel);
		this.playerPanel.add(winPlayer);
	}
	
	public void display(){
		if(!this.isVisible()){
			this.setVisible(true);
		}
	}
	
	public void playGame(int position){

			this.game.play(position);
			
			this.statusLabel.setText("Status: "+this.resultAnalyzer.getResult());
			
			
			if(this.game.getResultAnalyzer().getResult().equalsIgnoreCase("win"))
			{
				this.winPlayer.setText("WINNER IS "+this.game.getCurrentPlayer().toString());
			}else if(this.game.getResultAnalyzer().getResult().equalsIgnoreCase("draw")){
				this.winPlayer.setText("GAME IS DRAW..");
			}else{
				this.currentPlayerLabel.setText("Current Player: "+this.game.getTurn().toString());	
			}	
		
		display();
	}
}
