using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pickup : MonoBehaviour{

    public Text countText;

    private int count;

    void Start(){
        count = 0;
        SetCountText();
    }

    void Update(){
        
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pick Up")){ //Set collectable as Pick Up in tag menu
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText(){
        countText.text = "Count: " + count.ToString();
    }
}