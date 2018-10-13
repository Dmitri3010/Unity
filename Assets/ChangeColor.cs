using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour, IPointerClickHandler {



    float red, green, blue;
  
    void Start() { }

    void Update() { }
    public void OnPointerClick(PointerEventData eventData)
    {
        
        red = Random.Range(.0f, 1.0f);
        green = Random.Range(.0f, 1.0f);
        blue = Random.Range(.0f, 1.0f);
        Color newcolor = new Color(red, green, blue);
        int forse = 200;
    
        gameObject.GetComponent<Renderer>().material.color = newcolor;

        Vector3 target = eventData.pointerPressRaycast.worldPosition;
       
         Vector3 collid = Camera.main.transform.position;
        Vector3  distance = target-collid;
        distance = distance.normalized;
         collid = distance * forse;
        gameObject.GetComponent<Rigidbody>().AddForceAtPosition(collid, target);


    }

}
