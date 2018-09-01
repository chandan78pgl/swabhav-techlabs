package com.techlabs.player.test;

import com.techlabs.player.Player;

public class TestPlayer {
	public static void main(String[] args){
		Player player1 = new Player(101,"Chandan",22);
		Player player2 = new Player(102,"Dharmesh",21);
		
		printDetails(player1);
		printDetails(player2);
		
		Player result = player1.whoIsElder(player2);
		System.out.println("Elder Player is "+result.getName());
	}
	
	private static void printDetails(Player player){
		System.out.println("Id = "+player.getId()
				+"\nName = "+player.getName()
				+"\nAge = "+player.getAge());
		System.out.println("-------------------------------");
	}
}
