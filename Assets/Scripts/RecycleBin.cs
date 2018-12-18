using UnityEngine;
using UnityEngine.UI;

public class RecycleBin : MonoBehaviour {

    public Button Error1;// = GetComponent<Image>();
    public Text Error2;
    public Button Error3;
    public Button Error4;
    public Button Error5;
    public Button Error6;
    public Button Error7;
    public Button Error8;
    public Button Error9;
    public Button Error10;
    public Button Error11;

    void Start()
    {
        //Error = GetComponent<Button>();
    }

    public void OpenRecycleBin()
    {
        if(Error1.CompareTag("interactRecycle"))
        {
            Destroy(Error1.gameObject);
        }
        if(Error2.CompareTag("interactRecycle"))
        {
            Destroy(Error2.gameObject);
        }
        if (Error3.CompareTag("interactRecycle"))
        {
            Destroy(Error3.gameObject);
        }
        if (Error4.CompareTag("interactRecycle"))
        {
            Destroy(Error4.gameObject);
        }
        if (Error5.CompareTag("interactRecycle"))
        {
            Destroy(Error5.gameObject);
        }
        if (Error6.CompareTag("interactRecycle"))
        {
            Destroy(Error6.gameObject);
        }
        if (Error7.CompareTag("interactRecycle"))
        {
            Destroy(Error7.gameObject);
        }
        if (Error8.CompareTag("interactRecycle"))
        {
            Destroy(Error8.gameObject);
        }

        //ErrorButton.enabled = !ErrorButton.enabled;
        //ErrorImage.enabled = !ErrorImage.enabled;
        //Debug.Log("Button: " + ErrorButton.enabled + "|" + "Image: " + ErrorImage.enabled);
    }

}
