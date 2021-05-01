using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;

using System;



public class ACActuator : MonoBehaviour
{
    public string brokerEndpoint = "test.mosquitto.org";
	public int brokerPort = 1883;
	public string temperatureTopic = "casa/sala/temperature";
    public float temperatureUpperThreshold = 30f;
    public float temperatureLowerThreshold = 25f;
    private MqttClient client;
    string lastMessage;
    volatile bool acState = false;
    public GameObject acObject;
    // Start is called before the first frame update
    void Start()
    {
		client = new MqttClient(brokerEndpoint, brokerPort, false, null);

        client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 

		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId);

        client.Subscribe(new string[] { temperatureTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
    }

    void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) 
	{ 
		Debug.Log("Received: " + System.Text.Encoding.UTF8.GetString(e.Message)  );
		lastMessage = System.Text.Encoding.UTF8.GetString(e.Message);
        float temp;
        float.TryParse(lastMessage, out temp);

        if(temp >= temperatureUpperThreshold) 
        {
            acState = true;
        } 
        
        else if (temp <= temperatureLowerThreshold) 
        {
            acState = false;
        }
	}

    // Update is called once per frame
    void Update()
    {
        if (acState != acObject.activeSelf)
			acObject.SetActive(acState);
    }
}
