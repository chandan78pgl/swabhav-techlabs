package com.techlabs.multipleframes;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JFrame;

public class LoginHandler implements ActionListener{
	WelcomeFrame frame;
	
	public LoginHandler(WelcomeFrame frame) {
		this.frame=frame;
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		String data=this.frame.getLoginData();
		this.frame.setDisplayFrame(data);
	}
}
