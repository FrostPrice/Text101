using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // The SerializeField is used to make the Variable avaible to be changed in the Inspector tab
    [SerializeField] Text textComponent; // This is getting a property from the Text Class, and this Class is inside the UnityEngine.UI. The Text is a type of Variable, and text Component is the name of the Variable
    [SerializeField] State startingState; // When using a State put the State keyword for the type

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory(); // Here you're trying to acess the Text property inside the textComponent
    }
    
    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates(); // Var is a quick way to say that our Variable is created and initialized, and the type is assigned automatically

        // You can get the amount of elements that an Array have with the Lenght property
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index)) // Here we are adding the number 1 (Alpha1) to the current iteration (0)
            {
                state = nextStates[index]; // We area getting the state based on the current iteration
            }
        }
        
        textComponent.text = state.GetStateStory();
    }
}

// To add a State select the Game Object on Unity and then just select the State you want to use

// To use a Method inside of a Class simply, write the name of the class than a dot (.) and then the name of the Method you want to call