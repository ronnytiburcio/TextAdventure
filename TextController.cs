using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {Bed, Mirror, DownStairs, UpStairs, KeepLooking, LookAtPictures, Ignoreit, Door, SearchCloset, InvestigateSafe, RunToBathroom, LookForExit, Clothes, WriteOnDesk, ReadBackwards, WritingOnStomach, ReadWritingOnStomach, GrabKey, Freedom};
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
		}else if (MyState==States.LookForExit){
		state_LookForExit();
		}else if (MyState==States.RunToBathroom){
			state_RunToBathroom();
		}else if (MyState==States.SearchCloset){
			state_SearchCloset();
		}else if (MyState==States.InvestigateSafe){
		state_InvestigateSafe();
		}else if (MyState==States.LookAtPictures){
		state_LookAtPictures();
		}else if (MyState==States.Ignoreit){
		state_Ignoreit();
		}else if (MyState==States.UpStairs){
		state_UpStairs();
		}else if (MyState==States.KeepLooking){
		state_KeepLooking();
		}else if (MyState==States.DownStairs){
		state_DownStairs();
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
			  " quickly open the door. You made it but it seems like you are in some kind of institution."+
			  " You hear some noise, there is someone coming. What do I do?\n\n"+
			  "Press L to look for exit, Press C to go to closet, Press B to run in bathroom.";
		if (Input.GetKeyDown(KeyCode.L)){
		MyState=States.LookForExit;
		}
		if (Input.GetKeyDown(KeyCode.B)){
			MyState=States.RunToBathroom;
		}
		if (Input.GetKeyDown(KeyCode.C)){
			MyState=States.SearchCloset;
		}
	}
	void state_LookForExit(){
		text.text="While you are roaming and looking for an exit, you realize that you have no clothes on."+
				  " You have to find a way to blend in before they find out you dont belong here.\n\n"+
				  "Press R to return";
		if (Input.GetKeyDown(KeyCode.R)){
			MyState=States.GrabKey;
		}
	}
	void state_RunToBathroom(){
		text.text="You see a door slightly open and it looks like a bathroom. You begin to see if there are"+
				  " any clothes laying around and no lucky. Someone walks in so you quickly tip toe to the"+
				  " shower and hide there for about a few minutes until the guard finishes. Bathroom was a bad idea.\n\n"+
				  "Press R to return";
		if (Input.GetKeyDown(KeyCode.R)){
			MyState=States.GrabKey;
		}
	}
	void state_SearchCloset(){
		text.text=" You run inside the closet before anyone can see. Finally, some clothing. I put on"+
				  " some street clothes and I find a guards ID so I put in on along with a hat to cover my face."+
				  " There seems to be other interesting things in the closet. What is this place anyway. \n\n"+
				  "Press I to ignore it, S to investigate the Safe, L to look at the pictures on the wall";
		if (Input.GetKeyDown(KeyCode.S)){
			MyState=States.InvestigateSafe;
		}
		if (Input.GetKeyDown(KeyCode.L)){
			MyState=States.LookAtPictures;
		}
		if (Input.GetKeyDown(KeyCode.I)){
			MyState=States.Ignoreit;
		}
	}
	void state_InvestigateSafe(){
		text.text="I wonder how you open this. Maybe it's already open. Lets see......."+
				  " Whoa. I guess they bring people over here to use them as lab rats."+
				  " Why did I waste my time going through this, I gotta go. \n\n"+
				  "Press R to return";
		if (Input.GetKeyDown(KeyCode.R)){
			MyState=States.SearchCloset;
		}
	}
	void state_LookAtPictures(){
		text.text="There are some really creepy pictures on the wall. It's just a bunch of dead"+
				  " bodies. O god, I feel like puking. \n\n"+
				  "Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)){
			MyState=States.SearchCloset;
		}
	}
	void state_Ignoreit(){
		text.text="You decide to ignore everything and just get out. You walk down the hall and see two"+
				  " other on duty guards and you nod your head and they do the same. That was close."+
				  " You notice there is a set of stairs at the end of the hall. \n\n"+
				  "Press U to go upstairs, D to go downstairs, L to keep looking for exit on current floor.";
		if (Input.GetKeyDown(KeyCode.U)){
			MyState=States.UpStairs;
		}
		if (Input.GetKeyDown(KeyCode.L)){
			MyState=States.KeepLooking;
		}
		if (Input.GetKeyDown(KeyCode.D)){
			MyState=States.DownStairs;
		}
	}
	void state_UpStairs(){
		text.text="You walk up stairs and all you see is a bunch of doctors with bloody clothes walking"+
				  " from room to room. \n\n"+
				  "Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)){
			MyState=States.Ignoreit;
		}
	}
	void state_KeepLooking(){
		text.text=" You decide to stay on the same floor to see if you find an exit and no luck. \n\n"+
				  "Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)){
			MyState=States.Ignoreit;
		}
	}
	void state_DownStairs(){
		text.text="You walk downstairs and you see a red door. You pray and hope this leads to streets."+
				  " You are free you son of a gun. Now go home and never say a word about this. \n\n"+
				  "Press R to play again";
		if (Input.GetKeyDown(KeyCode.R)){
			MyState=States.Bed;
		}
	}
}