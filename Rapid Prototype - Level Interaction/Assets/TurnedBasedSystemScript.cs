using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class TurnedBasedSystemScript : MonoBehaviour
{
    /*
        playerTurnA is referring to player selecting an action 
        playerTurnB is referring to player selecting a enemy after 
        selecting a action.  
    */
    public enum States { setUp, playerTurnA, playerTurnB, enemyTurn, won, lose}
    public States state;
    public TextMeshProUGUI stateText; 
    public GameObject btnAction; 

    // Start is called before the first frame update
    void Start()
    {
        state = States.setUp;
        StartCoroutine(Setup()); 
    }

    IEnumerator Setup(){
        stateText.text = "Setting up...";
       
        yield return new WaitForSeconds(3f);

        StartCoroutine(PlayerTurn()); 
    }

    IEnumerator PlayerTurn(){
        stateText.text = "Player Turn: ";

        yield return new WaitForSeconds(1f);
        
        stateText.text = "Select action: ";
        state = States.playerTurnA;
    }

    void EnemyTurn(){
        stateText.text = "Enemy Turn: ";

        
    }
    
    void EndPhase(){
        // win 

        // lose
    }


    public GameObject Action{
        get { return btnAction; }
        set { btnAction = value; }
    }


    public void ButtonPressed(Button _btn){
        if(state != States.playerTurnA)
            return; 
        stateText.text = "Select Enemy: ";
        btnAction =  GameObject.Find("TestAttack");
        Debug.Log(_btn);
        Debug.Log(btnAction);
        // save btn, deactivate buttons, wait for enemy selection
        state = States.playerTurnB;
        StartCoroutine(WaitForSelectEnemy());
    }

    IEnumerator WaitForSelectEnemy(){
        yield return StartCoroutine(SelectEnemy());
    }

    private IEnumerator SelectEnemy(){
        bool loop = false; 
        while(!loop){
            // if click on enemy, loop = true
            //Debug.Log("in loop ");
            if(Input.GetKeyDown("backspace")){
                stateText.text = "Abort action... ";
                yield return new WaitForSeconds(2f);
                StartCoroutine(PlayerTurn()); 
                loop = true; 
            }

            //

            yield return null; 
        }

    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
