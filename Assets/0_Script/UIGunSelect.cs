using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGunSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    public void OnClickSelectGun(GameObject go)
    {
        UIManager.instance.gunFireUI.SpawnGun(go);
        UIManager.instance.gunSeletUI.gameObject.SetActive(false);
    }






}
