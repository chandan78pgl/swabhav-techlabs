package com.techlabs.prolinkedlist;

public class ProLinkedList<T> {
	private Node<T> headNode;
	private static int nodeCounter=0;
	
	public ProLinkedList() {
	}
	
	public void add(T data){
		if(headNode==null){
			headNode=new Node<T>(data);
		}
		
		Node<T> temp=new Node<T>(data);
		Node<T> currentNode=headNode;
		
		if(currentNode!=null){
			
			while(currentNode.getNextNode()!=null){
				currentNode=currentNode.getNextNode();
			}
			
			currentNode.setNextNode(temp);
		}
		
		nodeCounter++;
	}
	
	public T get(int index){
		if(index<0){
			return null;
		}
		Node<T> currentNode=null;
		
		if(headNode!=null){
			currentNode=headNode.getNextNode();
			
			for(int i=0;i<index;i++){
				if(currentNode.getNextNode()==null)
					return null;
				
				currentNode=currentNode.getNextNode();
			}
			
			return currentNode.getData();
		}
		return (T) currentNode;	
	}
	
	public Boolean remove(int index){
		if(index<1 || index>size())
			return false;
		
		Node<T> currentNode=headNode;
		
		if(headNode!=null){
			for(int i=0;i<index;i++){
				if(currentNode.getNextNode()==null){
					return false;
				}
				
				currentNode=currentNode.getNextNode();
			}
			
			currentNode.setNextNode(currentNode.getNextNode().getNextNode());
			nodeCounter--;
			return true;
		}
		return false;
	}
	
	private Integer getNodeCounter(){
		return nodeCounter;
	}
	
	public Integer size(){
		return getNodeCounter();
	}
}
