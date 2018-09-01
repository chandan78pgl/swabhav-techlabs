package com.techlabs.gameui;

import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import com.techlabs.tictactoe.MarkType;
import com.techlabs.tictactoe.Player;

public class PlayerFrame extends JFrame{
	private Player[] players=new Player[2];
	
	private JLabel fPlayerLabel;
	private JLabel sPlayerLabel;
	private JTextField fPlayerTextField;
	private JTextField sPlayerTextField;
	private JButton startButton;
	
	private JLabel headerLabel=new JLabel("",JLabel.CENTER);
	private JPanel controlPanel=new JPanel();
	
	public PlayerFrame() {
		createFrame();
	}
	
	public static void main(String[] args) {
		PlayerFrame playerFrame=new PlayerFrame();
	}
	
	private void createFrame(){
		this.setLayout(new GridLayout(3, 1));
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(500, 500);
		
		controlPanel.setLayout(new FlowLayout());
		
		setUIElements();
		
		this.add(headerLabel);
		this.add(controlPanel);
		this.add(startButton);
		this.pack();
		display();
	}
	
	private void setUIElements(){
		headerLabel.setText("Welcome to TicTacToe.");
		
		fPlayerLabel=new JLabel("",JLabel.CENTER);
		fPlayerLabel.setText("Enter First Player 'O'");
		
		fPlayerTextField=new JTextField(10);
	
		sPlayerLabel=new JLabel("",JLabel.CENTER);
		sPlayerLabel.setText("Enter Second PLayer 'X'");
		
		sPlayerTextField=new JTextField(10);
		
		startButton=new JButton("Click to Start Game");
		
		StartButtonHandler startButtonHandler=new StartButtonHandler(this);
		startButton.addActionListener(startButtonHandler);
		
		controlPanel.add(fPlayerLabel);
		controlPanel.add(fPlayerTextField);
		controlPanel.add(sPlayerLabel);
		controlPanel.add(sPlayerTextField);
	}
	
	public void setPlayers(){
		this.players[0]=new Player(this.fPlayerTextField.getText(), MarkType.NOUGHT);
		this.players[1]=new Player(this.sPlayerTextField.getText(), MarkType.CROSS);
	}
	
	public Player[] getPlayers(){
		return this.players;
	}
	
	public void display(){
		if(!this.isVisible()){
			this.setVisible(true);
		}else{
			this.setVisible(false);
		}
	}

}
