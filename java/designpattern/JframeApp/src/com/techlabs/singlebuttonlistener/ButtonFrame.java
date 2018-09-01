package com.techlabs.singlebuttonlistener;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;

public class ButtonFrame extends JFrame{
	
	
	public ButtonFrame(){
		createFrame();
	}
	
	public void createFrame(){
		this.setTitle("Buttons with single listner");
		this.setLayout(new FlowLayout());
		setDefaultLookAndFeelDecorated(true);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(500,500);
		
		JButton redButton= createButton("red");
		JButton blueButton= createButton("blue");
		
		redButton.setActionCommand("red");
		blueButton.setActionCommand("blue");
		
		ButtonHandler buttonHandler=new ButtonHandler(this.getContentPane());
		
		redButton.addActionListener(buttonHandler);
		blueButton.addActionListener(buttonHandler);
		
		this.add(redButton);
		this.add(blueButton);
		
		this.setVisible(true);
	}
	
	public JButton createButton(String buttonName){
		JButton button=new JButton("Change Color "+buttonName);
		button.setName(buttonName);
		System.out.println(button.getName());
			
		return button;
	}
}
