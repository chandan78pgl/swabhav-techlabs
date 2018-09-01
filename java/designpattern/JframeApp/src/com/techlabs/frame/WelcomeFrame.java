package com.techlabs.frame;

import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class WelcomeFrame extends JFrame{
	
	//Container c=this.getContentPane();
	
	public WelcomeFrame(){
		createFrame();
	}
	
	public void createFrame(){
		this.setTitle("This is a Welcome Frame");
		
		
		
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(500,500);
		
		
		JLabel label=new JLabel("Hello World..");
		
		createButton();
		
		
		this.add(label);
		this.setVisible(true);
		
	}
	
	public void createButton(){
		JButton button=new JButton("Click Button");
		button.setBounds(100, 100, 200, 200);
		button.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				System.out.println("Hello World");
				getContentPane().setBackground(Color.GREEN);
			}
		});
		this.add(button);
		
	}
}
