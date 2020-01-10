﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class midboss{ 
	private int hp = 50; 
	private int power = 15; 
	public int MP = 53; 
	public int used = 5;

	//攻撃用の関数
	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	} 
	//防御用の関数
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage; 
	}

	public void Magic(){ 

		//残りMPが５以下の場合の表示
		if(MP >= used){
			MP -= used;

			Debug.Log("魔法攻撃をした。残りMPは" + MP);}

		//残りMPが５以上の場合の表示
		else if(MP <= used) {Debug.Log("MPが足りないため、魔法が使えない");

		}
	}
}	



public class First{

	public void testcase1(){
		//配列を初期化し、宣言する
		int[] array = { 10, 100, 50, 30, 80, 120 };
		//配列の要素数の分だけ処理を繰り返す
		for (int i = 0; i < array.Length; i++) {
			//配列の要素が10以上の場合
			if (array [i] >= 10) {
				//配列の要素を表示する
				Debug.Log (array [i]); 
			}
		}
	}
}

public class second{
	
	public void testcase2(){
		//配列を初期化し、宣言する
		int[] array = { 10, 50, 70, 90, 100 }; 
		//配列の要素数の分だけ処理を繰り返す
		for(int u = 4; u >= 0; u--){
			//配列の要素が0以上の場合
			if(array[u] >= 0) {
				Debug.Log (array [u]);

			}
		}
	}
}




public class Test : MonoBehaviour{
	

	void Start(){

		//魔法攻撃の処理回数　
		int MagicAblibleTimes = 10;

		//midbossクラスの変数を宣言してインスタンスを代入
		midboss midiaumBoss = new midboss ();
		//攻撃用の関数を呼び出す
		midiaumBoss.Attack ();
		//防御用の関数を呼び出す
		midiaumBoss.Defence (2);

		//MP５以下になるまでループ
		for (int i = 0; i < MagicAblibleTimes; i++){
			midiaumBoss.Magic (); 
		}


		//testcase1のクラス変数名宣言してインスタンスを代入
		First TestcaseFirst = new First ();
		//testcase1の関数を呼び出す　
		TestcaseFirst.testcase1 (); 

		//testcase2のクラス変数名を宣言してインスタンスを代入
		second testes = new second (); 
		//testcase2の関数を呼び出す
		testes.testcase2 ();
						
	
	}
}