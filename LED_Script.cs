using System.Collections;
using UnityEngine;
using System.IO.Ports;
using TMPro;

public class LED_Script : MonoBehaviour
{
    //Connects the Serial port of the arduino to unity
    public SerialPort serial = new SerialPort("COM3", 9600);
    public TMP_Text Output;
    private string getLine;

    void Start()
    {
        serial.Open();
    }

    void Update()
    {
        //gets the temperature from the arduino
        getLine = serial.ReadLine();
        //Outputs the temperature
        Output.text = getLine;
    }

    //ON BUTTON
    public void OnLED()
    {
        if (serial.IsOpen == false)
        {
            serial.Open();
        }
        //Sends "A" to arduino to turn ON
        serial.Write("A");
        Debug.Log("On");
    }
    //OFF BUTTON
    public void OffLED()
    {
        if (serial.IsOpen == false)
        {
            serial.Open();
        }
        //Sends "a" to arduino to turn OFF
        serial.Write("a");
        Debug.Log("Off");
    }

    
}
