using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scenetransition : MonoBehaviour {
	public GameObject nextpage;
	public string output;
	public InputField inputfield;
	public bool timeinput = false;
	public bool gopage = false;
	public bool isinital = false;
	public bool isfinal = false;
	private Button gobutton;
	// Use this for initialization
	void Start () {
		gobutton = GetComponentInChildren<Button>();
		gobutton.onClick.AddListener(TaskOnClick);
		Debug.Log (gobutton);
		if (timeinput)
		{
			inputfield= GetComponent<InputField>();
		}
		if (!isinital) {
			gameObject.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		gameObject.SetActive (false);
		if (nextpage) {
			nextpage.SetActive (true);
		}
		if (isfinal) {
			//Make Transition here!!!
		}

	}

}
