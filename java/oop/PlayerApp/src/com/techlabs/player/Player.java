package com.techlabs.player;

public class Player {
	private int id;
	private String name;
	private int age=18;
	
	public Player(int id, String name,int age){
		this.id=id;
		this.name=name;
		this.age=age;
	}
	
	public Player(int id,String name){
		this.id=id;
		this.name=name;
	}
	
	public int getId(){
		return id;
	}
	
	public String getName(){
		return name;
	}
	
	public int getAge(){
		return age;
	}
	
	public Player whoIsElder(Player player){
		if(this.age<player.age){
			return player;
		}
		return this;
	}
	
	@Override
	public boolean equals(Object object){
		Player player=(Player) object;
		if(this.id==player.getId() && this.name==player.getName() && this.age==player.getAge())
			return true;
		return false;
	}
}
