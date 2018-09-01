package com.techlabs.multipleframes;


import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

public class WelcomeFrame extends JFrame{
	/**
	 * 
	 */
	private static final long serialVersionUID = 6786972982088530352L;
	private JFrame loginFrame=createFrame("Login Frame");
	private JFrame displayFrame=createFrame("Display Frame");
	private JLabel headerLabel=new JLabel("",JLabel.CENTER);
	private JLabel statusLabel=new JLabel("",JLabel.CENTER);
	private JPanel controlPanel=new JPanel();
	private JTextField userText;
	private JPasswordField passwordText;
	private LoginHandler loginHandler=new LoginHandler(this);
	
	public WelcomeFrame() {
		setLoginLayout();
	}
	
	private void setLoginLayout(){
		loginFrame.setLayout(new GridLayout(3,1));
		
		headerLabel.setText("Welcome To Login Page");
		
		controlPanel.setLayout(new GridLayout(0,1));

		loginFrame.add(headerLabel);
		loginFrame.add(controlPanel);
		
		createLoginGUI();
		display();
	}
	
	public String getLoginData(){
		return "Username: "+userText.getText()+"  Password: "+new String(passwordText.getPassword());
	}
	
	public void setDisplayFrame(String data){
		displayFrame.setLayout(new FlowLayout());
		statusLabel.setSize(200, 100);
		displayFrame.add(statusLabel);
		statusLabel.setText(data);
		display();
	}
	
	public void createLoginGUI(){
		JLabel nameLabel=new JLabel("UserID: ",JLabel.CENTER);
		JLabel passwordLabel=new JLabel("Password: ",JLabel.CENTER);
		
		userText=new JTextField(10);
		passwordText=new JPasswordField(10);

		
		JButton loginButton=new JButton("Login");
		
		loginButton.addActionListener(loginHandler);
		
		controlPanel.add(nameLabel);
		controlPanel.add(userText);
		controlPanel.add(passwordLabel);
		controlPanel.add(passwordText);
		controlPanel.add(loginButton);
	}
	
	public JFrame createFrame(String frameName){
		JFrame frame=new JFrame(frameName);
		frame.setTitle(frameName);
		frame.setDefaultCloseOperation(EXIT_ON_CLOSE);
		frame.setSize(500, 500);
		
		return frame;
	}
	
	public void display(){
		if(loginFrame.isVisible()){
			loginFrame.setVisible(false);
			displayFrame.setVisible(true);
		}else
			loginFrame.setVisible(true);
	}
}
