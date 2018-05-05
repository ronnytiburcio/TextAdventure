using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {Bed, Mirror, Door, Clothes, WriteOnDesk, ReadBackwards, WritingOnStomach, ReadWritingOnStomach, GrabKey, Freedom};
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
		}else if (MyState== States.Mirror){
		state_Mirror();
		}else if (MyState== States.ReadWritingOnStomach){
		state_ReadWritingOnStomach();
		}else if (MyState== States.ReadBackwards){
		state_ReadBackwards();
		}else if (MyState== States.WriteOnDesk){
		state_WriteOnDesk();
		}else if (MyState==States.GrabKey){
		state_GrabKey();
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
		} else if (Input.GetKeyDown(KeyCode.M)){
		MyState=States.Mirror;
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
	void state_Mirror(){
	text.text="What the fu%<! Why would I write on my stomach? How drunk was I?"+
			  " I wonder what it says............\n\n"+
			  "Press S to read what it says, Press R to roam the room";
		if(Input.GetKeyDown(KeyCode.S)){
		MyState=States.ReadWritingOnStomach;
		}
		else if (Input.GetKeyDown(KeyCode.R)){
		MyState=States.Bed;
		}
	}
	void state_ReadWritingOnStomach(){
	text.text="It seems like I wrote it backwards. I guess I am a skilled backwards"+
		      " writer when I'm wasted. Or maybe it's just that I am looking at it"+
		      " from a mirror.\n\n"+
		      "Press B to try to read it,Press W to write it out on desk";
		 if (Input.GetKeyDown(KeyCode.B)){
		 MyState=States.ReadBackwards;
		 }
		 else if (Input.GetKeyDown(KeyCode.W)){
		 MyState=States.WriteOnDesk;
		 } 
	   }
	void state_ReadBackwards(){
	text.text="Now what does this say? Hmmmmmmmm. After 5 minutes of trying to figure this out"+
			  ", maybe it's time for me to accept that I am way to drunk to attempt this. \n\n"+
			  "Press S to return";
		if (Input.GetKeyDown(KeyCode.S)){
		MyState=States.Mirror;
		}
	}	
	void state_WriteOnDesk(){
	text.text="After writing it out and maneuvering the letters I was finally able to read out"+
			  " what my drunk self left my kinda drunk self left me. The words spelled out"+
			  " She hid the key under the pillow, Get out.\n\n"+
			  "Press P to grab the key under the pillow.";
		if (Input.GetKeyDown(KeyCode.P)){
		MyState=States.GrabKey;
		}
	}
	void state_GrabKey(){
	text.text="You slowly walked over to her side of the bed trying to ignore the squeeky tiles"+
			  " on the ground. You slowly reach your arm under the pillow and you feel a cold piece"+
			  " of shape metal. Its the Key. Out of excitement you agressiveley pull your arm out"+
			  " quickly open the door. You made it you son of a gun. You are free. naked but free.\n\n"+
			  "Press Spacebar to start all over, other wise you can close this app.";
		if (Input.GetKeyDown(KeyCode.Space)){
		MyState=States.Bed;
		}
	}
}