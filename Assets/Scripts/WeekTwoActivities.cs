using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielCairney
{
   

    public class WeekTwoActivities : MonoBehaviour
    {
        private string myFavouriteGame = "BloodBorne";
        private int hoursPlayed = 200;
        private float costOfGame = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" My favourite game is " + myFavouriteGame + " I have played it for " + hoursPlayed + " Hours, and it cost me $ " + costOfGame + " Therefore, my value of dollars per hour is " + (costOfGame/ hoursPlayed) + "/hr.");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}