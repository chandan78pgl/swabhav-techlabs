package com.techlabs.buttons;

import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class BlueButtonHandler implements ActionListener{

	Container frame;
	
	public BlueButtonHandler(Container frame) {
		this.frame=frame;
	}
	
	@Override
	public void actionPerformed(ActionEvent arg0) {
		this.frame.setBackground(Color.BLUE);
	}

}
