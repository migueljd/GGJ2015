using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadOnClick : MonoBehaviour {

	public Image background;
	public Image credits;
	public Image back;
	public Button b1;
	public Button b2;
	public Button b3;
	public Button b4;


	public void LoadScene(int level){
		if(level == 2){
			credits.enabled = true;
			b4.enabled = true;
			background.enabled = false;
			b1.enabled = false;
			b2.enabled = false;
			b3.enabled = false;
			back.enabled = true;
		}
		else if(level == 0){
			credits.enabled = false;
			b4.enabled = false;
			background.enabled = true;
			b1.enabled = true;
			b2.enabled = true;
			b3.enabled = true;
			back.enabled = false;
		}
		else {
			Application.LoadLevel(level);
		}
	}

	public void ExitGame(){
		Application.Quit();
	}
}
