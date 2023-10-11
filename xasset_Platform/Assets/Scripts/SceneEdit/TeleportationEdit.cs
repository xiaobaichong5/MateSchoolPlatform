using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using libx;
public class TeleportationEdit : MonoBehaviour
{
    [Header("在传送阵多久传送")]
    public int time = 100;    // 在阵内多少时间传送
    [Header("要传送到的场景名称")]
    public string InScenceName; // 要传送到的场景
    [Header("要传送到的场景名称")]
    public string InScenceId;
    [Header("显示标题")]
    public string TitileName;   // 显示标题文本
    [Header("下载地址")]
    public string url;
    [Space]
    public TextMesh title;
    private int _time;
    private bool isIn = false;
    private void Start()
    {
        title.text = TitileName;
    }
    private void Update()
    {
        if (Camera.main)
        {
            title.transform.LookAt(Camera.main.transform);
        }
        title.transform.Translate(Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * 0.2f, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        _time = 0;
        isIn = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            _time++;
            if (_time > time && isIn == false)
            {
                // TODO 切换场景
                GetComponent<Updater_Item>().LoadItem(url, InScenceId, InScenceName);
                Global.currentchildsceneid = InScenceId;
                isIn = true;
            }
        }
    }
    public void OnProgess(string str)
    {
        title.text = TitileName + str;
    }
    private void OnTriggerExit(Collider other)
    {
        _time = 0;
        isIn = false;
    }
}
