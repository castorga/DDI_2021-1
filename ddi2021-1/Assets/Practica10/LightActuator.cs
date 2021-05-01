using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;

using System;
public class LightActuator : MonoBehaviour
{
    public string brokerEndpoint = "test.mosquitto.org";
	public int brokerPort = 1883;
	public string presenceTopic = "casa/sala/presence";
    private MqttClient client;
    public GameObject Light;
    public Material onMaterial;
    public Material offMaterial;
    string lastMessage;
    bool lightState;
    // Start is called before the first frame update
    void Start()
    {
		client = new MqttClient(brokerEndpoint, brokerPort, false, null);
        client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId);
        client.Subscribe(new string[] { presenceTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
    }

    void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) 
	{ 
		Debug.Log("Received: " + System.Text.Encoding.UTF8.GetString(e.Message)  );
		lastMessage = System.Text.Encoding.UTF8.GetString(e.Message);
        bool flag;
        Boolean.TryParse(lastMessage, out flag);
        lightState = flag;
	}


    // Update is called once per frame
    void Update()
    {
        if(lightState)
            Light.GetComponent<MeshRenderer> ().material = onMaterial;
        else
            Light.GetComponent<MeshRenderer> ().material = offMaterial;
    }
}
