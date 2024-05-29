using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginPopup : MonoBehaviour
{
    [SerializeField] private InputField Input_NetworkAdress;
    [SerializeField] private InputField Input_UserName;

    [SerializeField] private Button Btn_StartAsHostServer;
    [SerializeField] private Button Btn_StartAsClient;

    [SerializeField] private Text Text_Error;

    private string _originNetworkAddress;
    // private string m_originNetworkAddress;
    // private string originNetworkAddress;

    private void Awake()
    {
    }

    private void Start()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void Update()
    {
    }

    public void OnClick_StartAsHost()
    {

    }

    public void OnClick_StartAsClient()
    {

    }

    public void OnValueChanged_ToggleButton(string userName)
    {

    }
}
