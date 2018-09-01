package com.techlabs.testdatastructures.sortedaccount.test;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashSet;
import java.util.TreeSet;

import com.techlabs.testdatastructures.Customer;
import com.techlabs.testdatastructures.sortedaccount.Account;

public class TestAccountList {
	private static class BalanceCompare implements Comparator<Account>{
		@Override
		public int compare(Account account1, Account account2) {
			return account1.getBalance().compareTo(account2.getBalance());
		}
	}
	
	private static class NameCompare implements Comparator<Account>{
		@Override
		public int compare(Account account1, Account account2) {
			return account1.getName().compareTo(account2.getName());
		}	
	}
	
	public static void main(String[] args) {
		implementHashSet();
	}
	
	
	private static void implementHashSet(){
		HashSet<Account> accountset=new HashSet<Account>();
		
		Account account1=new Account(101, "Chandan",5000.0);
		Account account2=new Account(102, "Dharmesh",2000.0);
		Account account3=new Account(103, "Foo",8000.0);
		Account account4=new Account(104, "Bar",4000.0);
		
		accountset.add(account1);
		accountset.add(account2);
		accountset.add(account3);
		accountset.add(account4);
		
		System.out.println(sortByName(accountset));
		System.out.println(sortByBalance(accountset));
	}


	private static ArrayList<Account> sortByBalance(HashSet<Account> accountset) {
		ArrayList<Account> accountList = new ArrayList<Account>(accountset);
		
		BalanceCompare balanceCompare=new BalanceCompare();
		Collections.sort(accountList, balanceCompare);
		
		return accountList;
	}


	private static ArrayList<Account> sortByName(HashSet<Account> accountset) {
		ArrayList<Account> accountList = new ArrayList<Account>(accountset);
		
		NameCompare nameCompare=new NameCompare();
		Collections.sort(accountList, nameCompare);

		return accountList;
	}
}
