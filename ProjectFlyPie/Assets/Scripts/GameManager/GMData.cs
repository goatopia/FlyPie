using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMData : MonoBehaviour
{
    //this is data used by the game manager
    public bool hasStarted; //has the game been started by the player yet?
    public bool hasAnswered; //has the player submitted information to the fly?
    public int regulator; //int used to prevent certain code from running more than it should
}
