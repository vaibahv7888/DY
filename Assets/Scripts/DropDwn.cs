using UnityEngine;
using System.Collections;

public class DropDwn : MonoBehaviour {

	private Vector2 scrollViewVector = Vector2.zero;
	private string[] countrys = {"Any country","Afghanistan", "Albania", "Algeria"};//add the rest
	int n,i,wichcountry;
	
	void Start () {
		n=0;i=0;wichcountry=0;
	}
	
	void OnGUI () {

		GUI.Label(new Rect(30,25,300,25), "Source");
		if (GUI.Button (new Rect (25, 50, 200, 25), countrys[wichcountry])) {

		}
		GUI.Label(new Rect(30,75,300,25), "Destination");

		if(GUI.Button(new Rect(25,100,200,25), "")){
			if(n==0)n=1;
			else n=0;        
		}
		
		if(n==1){
			scrollViewVector = GUI.BeginScrollView (new Rect (25, 125, 200, 200), scrollViewVector, new Rect (0, 0, 200, 200));
			GUI.Box(new Rect(0,0,300,500), ""); 
			for(i=0;i<4;i++){
				if(GUI.Button(new Rect(0,i*25,300,25), countrys[i])){
					n=0;wichcountry=i;        
				}              
//				GUI.Label(new Rect(5,i*25,300,25), countrys[i]);           
			}
			GUI.EndScrollView();        
		}else{
//			GUI.Label(new Rect(30,50,300,25), countrys[wichcountry]);
		}
		GUI.Label(new Rect(30,100,300,25), countrys[wichcountry]);
	}
}