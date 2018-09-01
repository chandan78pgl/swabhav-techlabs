package com.techlabs.prolinkedlist;

public class Node<T> {
	private T data;
	private Node<T> next;
	
	public Node(T data) {
		this.data=data;
		this.next=null;
	}
	
	public T getData(){
		return this.data;
	}
	
	public Node<T> getNextNode(){
		return this.next;
	}
	
	public void setNextNode(Node<T> node){
		this.next=node;
	}
	
	public void setData(T data){
		this.data=data;
	}
}