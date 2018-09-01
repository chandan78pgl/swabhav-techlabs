package com.techlabs.buttons;

import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class RedButtonHandler implements ActionListener{
	Container frame;
	
	public RedButtonHandler(Container frame) {
		this.frame=frame;
	}
	
	@Override
	public void actionPerformed(ActionEvent arg0) {
		this.frame.setBackground(Color.RED);
	}

}
