package com.techlabs.buttons;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;

public class ButtonsFrame extends JFrame{
	
	
	public ButtonsFrame(){
		createFrame();
	}
	
	public void createFrame(){
		this.setTitle("Buttons with multiple listner");
		this.setLayout(new FlowLayout());
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(500,500);
		
		JButton redButton= createButton("red");
		JButton blueButton= createButton("blue");
		
		RedButtonHandler redHandler=new RedButtonHandler(this.getContentPane());
		BlueButtonHandler blueHandler=new BlueButtonHandler(this.getContentPane());
		
		redButton.addActionListener(redHandler);
		blueButton.addActionListener(blueHandler);
		
		this.add(redButton);
		this.add(blueButton);
		
		this.setVisible(true);
	}
	
	public JButton createButton(String buttonName){
		JButton button=new JButton("Change Color");
		button.setName(buttonName);
		System.out.println(button.getName());
		button.setSize(200, 100);
			
		return button;
	}
}
