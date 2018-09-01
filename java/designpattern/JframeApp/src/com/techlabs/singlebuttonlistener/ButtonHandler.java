package com.techlabs.singlebuttonlistener;

import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;

public class ButtonHandler implements ActionListener{
	
	Container frame;
	
	public ButtonHandler(Container frame) {
		this.frame=frame;
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		if(e.getActionCommand().equals("red")){
			this.frame.setBackground(Color.RED);
		}else if(e.getActionCommand().equals("blue")){
			this.frame.setBackground(Color.BLUE);
		}
	}

}
