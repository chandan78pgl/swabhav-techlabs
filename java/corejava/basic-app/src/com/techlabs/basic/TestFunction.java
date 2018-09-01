package com.techlabs.basic;

public class TestFunction {
	public static void main(String[] args) {
		int mark = 100;
		changemarkstozero(mark);
		System.out.println(mark);
		
		int marks[]={20,30,40,50};
		changeMarksToZero(marks);
		for(int tmark :marks){
			System.out.println(tmark);
		}
	}

	private static void changemarkstozero(int pmark) {
		pmark = 0;
	}
	
	private static void changeMarksToZero(int[] pmarks){
		for(int i=0;i<pmarks.length;i++){
			pmarks[i]=0;
		}
	}
}
