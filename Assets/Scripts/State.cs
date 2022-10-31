using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")] // This line allow us to create Scriptable Objects from our Inspector, right click the Assests area, then create and then the name that you putted in the String, doing this creates a new Scriptable Object
public class State : ScriptableObject // You need to change the class to ScriptableObject
{
    // The TextArea Method will change the size of the text area in the inspector, the first parameter is the minimn size of the field, and the second is the amount of line it will have before we need to scroll
  [TextArea(10,14)] [SerializeField] string storyText;

    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
    
}

// Public can be used in our entire project, to turn a Method Public use the public keyword, while private can only be used in the same scope, to turn a Method Private use the private keyword

// To make a Function return a Value, before the name of the function, write the type of Data that it will return (string, int, etc), and inside the declaration Block use the return keyword