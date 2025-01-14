using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnterName : MonoBehaviour
{
 public TextMeshProUGUI output;
 public TextMeshProUGUI output2;
    public TMP_InputField userName;

    public void ButtonDemo()
    {
        output.text = "kontan wè ou " + userName.text +"!!!";
        output2.text = userName.text;
    }
}
