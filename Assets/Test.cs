using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class midboss{ 
	private int hp = 50; 
	private int power = 15; 

	//攻撃用の関数
	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	} 
	//防御用の関数
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage; 
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


public class third{

	//変数MPを53で初期化する
	int MP = 53; 

	public void Magic(int used){ 
		//MP５以下になるまでループ
		for(int result = MP; result > 0; result -= 5){ 

			//残りMPが５以下の場合の表示
			if(result < 5){Debug.Log("MPが足りないため、魔法が使えない");}

			//残りMPが５以上の場合の表示
			else if(result > 5){Debug.Log("魔法攻撃をした。残りMPは" + result);
			  }
         }
	}	
}


public class Test : MonoBehaviour{
	

	void Start(){
		
		//midbossクラスの変数を宣言してインスタンスを代入
		midboss midiaumBoss = new midboss ();
		//攻撃用の関数を呼び出す
		midiaumBoss.Attack ();
		//防御用の関数を呼び出す
		midiaumBoss.Defence (2);

		//testcase1のクラス変数名宣言してインスタンスを代入
		First TestcaseFirst = new First ();
		//testcase1の関数を呼び出す　
		TestcaseFirst.testcase1 (); 

		//testcase2のクラス変数名を宣言してインスタンスを代入
		second testes = new second (); 
		//testcase2の関数を呼び出す
		testes.testcase2 ();
						
			
		//関数Magicのクラス変数名を宣言してインスタンスを代入　
		third motion = new third(); 
		//Magic関数を引数を与えて呼び出す。　
		motion.Magic(5);

		Debug.Log ("動いていますか？");
	}
}