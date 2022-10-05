using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureChecker : MonoBehaviour
{
    [SerializeField] private float porridgeTemperature = 85.0f;

    private float hotLimitTemperature = 70.0f;
    private float coldLimitTemperature = 40.0f;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             TemperatureTest();
        }
       

        porridgeTemperature -= Time.deltaTime * 5f;
    }
    
    void TemperatureTest()
    {
        if (porridgeTemperature > hotLimitTemperature)
        {     
        
            Debug.Log("The temperature is too hot YAAAAAAOOOOOWWWWWWW. " + (int)porridgeTemperature);
        }
         
         else if (porridgeTemperature < coldLimitTemperature)
        {
           
          Debug.Log("THAT IS WAY TOO COLD JKADSGHDJAKSFHADJSKFHDFHLK " + (int)porridgeTemperature);

        }
         
         else
        {
           Debug.Log("Yeeeaaahh that is GOOODD " + (int)porridgeTemperature);
        
        }
         
     

    }   

}
