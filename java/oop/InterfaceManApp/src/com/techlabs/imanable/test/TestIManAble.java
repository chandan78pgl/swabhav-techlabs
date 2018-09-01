package com.techlabs.imanable.test;

import com.techlabs.imanable.Boy;
import com.techlabs.imanable.IEmotionAble;
import com.techlabs.imanable.IMannerAble;
import com.techlabs.imanable.Man;

public class TestIManAble {
	public static void main(String[] args) {
		Man man=new Man();
		Boy boy=new Boy();
		
		atTheParty(man);
		atTheParty(boy);
		//atTheCinemas(man);
		atTheCinemas(boy);
	}
	
	public static void atTheParty(IMannerAble iMannerAble){
		iMannerAble.wish();
		iMannerAble.depart();
	}
	
	public static void atTheCinemas(IEmotionAble iEmotionAble){
		iEmotionAble.cry();
		iEmotionAble.laugh();
	}
}
