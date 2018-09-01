package com.techlabs.player.test;

import com.techlabs.player.Player;

public class TestEquality {
	public static void main(String[] args){
		Player player1 = new Player(101,"Chandan", 22);
		Player player2 = new Player(101,"Chandan", 22);
		
		if(player1.equals(player2)){
			System.out.println("True\n");	
		}
		else{
			System.out.println("False\n");
		}
	}
}
