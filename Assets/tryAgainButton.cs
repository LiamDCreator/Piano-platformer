using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tryAgainButton : MonoBehaviour
{
 public Button yourButton;
 public GameObject Player;
 public GameObject playerDiedScreen;
	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		 Player.SetActive(true);
        playerDiedScreen.SetActive(false);
        Player. transform.position=new Vector3(-9,-1,0);
	}
}