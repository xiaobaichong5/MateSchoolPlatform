﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
public class WebRequestController : MonoBehaviour
{
    public static WebRequestController Instance;
    public const string SerectKey = "BjLkjtTLaVFteXSx";
    /// <summary>
    /// 时间戳
    /// </summary>
    public long Timestamp
    {
        get
        {
            var dateTime = DateTime.Now;
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.Ticks / 10000);
        }
    }
    private void Awake()
    {
        Instance = this;
        //DontDestroyOnLoad(this);
    }
    public void Post(string url, WWWForm form, Dictionary<string, string> header, Action<string> action = null)
    {
        StartCoroutine(PostCoroutine(url, form, header, action));
    }


    public void Put(string url, string json, Dictionary<string, string> header, Action<string> action = null)
    {
        StartCoroutine(PutCoroutine(url, json, header, action));
    }


    public void Post(string url, string form, Dictionary<string, string> header, Action<string> action = null)
    {
        StartCoroutine(PostCoroutine(url, form, header, action));
    }

    public void Get(string url, string token, Action<string> action = null)
    {
        StartCoroutine(GetCoroutine(url, token, action));
    }

    private IEnumerator GetCoroutine(string url, string token, Action<string> action)
    {
        var webrequest = UnityWebRequest.Get(url);
        webrequest.SetRequestHeader("Content-Type", "application/json");

        if (token.Contains("bearer"))
        {
            webrequest.SetRequestHeader("Authorization", token);
        }
        else
        {
            webrequest.SetRequestHeader("Authorization", "bearer " + token);
        }
        yield return webrequest.SendWebRequest();
        var data = webrequest.downloadHandler.text;
        action?.Invoke(data);
    }

    private IEnumerator PostCoroutine(string url, WWWForm form, Dictionary<string, string> header, Action<string> action = null)
    {
        var webrequest = UnityWebRequest.Post(url, form);
        foreach (var item in header)
        {
            webrequest.SetRequestHeader(item.Key, item.Value);
        }
        yield return webrequest.SendWebRequest();
        var data = webrequest.downloadHandler.text;
        webrequest.Dispose();
        action?.Invoke(data);
    }

    private IEnumerator PostCoroutine(string url, string form, Dictionary<string, string> header, Action<string> action = null)
    {
        var webrequest = UnityWebRequest.Post(url, form);

        if (header != null)
        {
            foreach (var item in header)
            {
                webrequest.SetRequestHeader(item.Key, item.Value);
            }
        }
        webrequest.SetRequestHeader("Content-Type", "application/json;charset=utf-8");

        byte[] bodyRaw = Encoding.UTF8.GetBytes(form);
        using (webrequest.uploadHandler = new UploadHandlerRaw(bodyRaw))
        {
            yield return webrequest.SendWebRequest();
            webrequest.uploadHandler.Dispose();

            var data = webrequest.downloadHandler.text;
            action?.Invoke(data);
            webrequest.Dispose();
            //webrequest.disposeDownloadHandlerOnDispose = true;
            //webrequest.disposeUploadHandlerOnDispose = true;
        }

    }
    private IEnumerator PutCoroutine(string url, string form, Dictionary<string, string> header, Action<string> action = null)
    {
        var webrequest = UnityWebRequest.Put(url, form);

        if (header != null)
        {
            foreach (var item in header)
            {
                webrequest.SetRequestHeader(item.Key, item.Value);
            }
        }
        webrequest.SetRequestHeader("Content-Type", "application/json");
        yield return webrequest.SendWebRequest();
        var data = webrequest.downloadHandler.text;
        action?.Invoke(data);
    }
    public string EncryMd5(string timestamp, string jsonstr)
    {
        //获得当前时间戳
        //string timestamp = Timestamp.ToString();
        //拼接请求密文
        StringBuilder urlParamBuilder = new StringBuilder();
        urlParamBuilder.Append(SerectKey);
        urlParamBuilder.Append(jsonstr);
        urlParamBuilder.Append(timestamp);
        urlParamBuilder.Append(SerectKey);
        Debug.Log(urlParamBuilder.ToString());
        //加密并返回密文加密头
        return MD5Encrypt32(urlParamBuilder.ToString());

    }
    public static string MD5Encrypt32(string password)
    {
        string cl = password;
        string pwd = "";
        MD5 md5 = MD5.Create(); //实例化一个md5对像
                                // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
        byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
        // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
        for (int i = 0; i < s.Length; i++)
        {
            // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
            pwd = pwd + s[i].ToString("x2");
        }
        return pwd;
    }
}