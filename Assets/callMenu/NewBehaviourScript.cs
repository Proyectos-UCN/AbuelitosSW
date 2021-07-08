using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
      bool state;
  
      public void SwitchShowHide()
      {
          state = !state; 
          panel.gameObject.SetActive (state);
      }
}
