using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;

using System;
public class presenceSensor : MonoBehaviour
{
    public string brokerEndpoint = "test.mosquitto.org";
	public int brokerPort = 1883;
	public string presenceTopic = "casa/sala/presence";
    private MqttClient client;

    public bool lastValue = true;

    public TriggerObject triggerObject;
    // Start is called before the first frame update
	void Start () {
		client = new MqttClient(brokerEndpoint, brokerPort, false, null);
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId);
	}

    // Update is called once per frame
    void Update()
    {
        if(!client.IsConnected) {
            Debug.LogWarning("No conectado");
            return;
        }
        if(triggerObject.getTriggerState() != lastValue) {
            Debug.Log($"sending to topic... {presenceTopic}, value: {triggerObject.getTriggerState()}");
            string message = triggerObject.getTriggerState().ToString();
            client.Publish(presenceTopic, System.Text.Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            Debug.Log("sent");
            lastValue = triggerObject.getTriggerState();
        }
    }
}
