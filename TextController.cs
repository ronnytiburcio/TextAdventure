using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {Bed, Mirror, Door, Clothes,BrakeMirror, WritingOnStomach, ReadWritingOnStomach, GrabKey, Freedom};
	private States MyState;  
	
	
	// Use this for initialization
	void Start () {
	MyState= States.Bed;
	}
	
	// Update is called once per frame
	void Update () {
		print (MyState);
		if (MyState== States.Bed){
		state_bed();
		} else if (MyState== States.Door){
		  state_Door();
		}else if (MyState== States.Clothes){
		state_Clothes();
		}
	}
	void state_bed(){
		text.text="You wake up in a bed that you do not recognize."+
				  "There is a girl you do not know sleeping next to you."+
				  "The door is closed. You need a Key to get out."+ 
				  "Your clothes are on the ground. You are naked."+
				  "In front of the bed is a desk and on the other corner, a mirror."+
				  "Get out before she wakes up!\n\n"+
				  "Press D to walk to door, M to view mirror, C to pick up clothes";
		if (Input.GetKeyDown(KeyCode.D)){
			MyState= States.Door;
		} else if (Input.GetKeyDown(KeyCode.C)){
		MyState=States.Clothes;
		}
	} 
	void state_Door(){
		text.text= "The Door seems to be locked from the inside and it's not budging."+
				   "What the fuck did I do last night?"+
				   "Why did she lock the door? Did she lock the door?"+
				   "I gotta stop thinking, my head is pounding.\n\n"+
				   "Press R to continue to roam the room";
		if (Input.GetKeyDown(KeyCode.R)){
			MyState= States.Bed;
}
}
	void state_Clothes(){
		text.text="Maybe I should put my clothes on. SHIT! The girl is moving."+
				  "On second thought maybe I should wait till I find this key first."+
				  "Who is this girl? All I remember is taking shots and I wake up with"+
				  " a passed out girl and a sore penis. My boys will be proud.\n\n"+
				  "Press R to continue to roam the room"; 
		if (Input.GetKeyDown(KeyCode.R)){
			MyState= States.Bed;
		}
	}
}