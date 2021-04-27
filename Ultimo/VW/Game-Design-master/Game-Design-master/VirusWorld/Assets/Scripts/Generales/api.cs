/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Script with the general function of sending data to the database
*/

using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class api : MonoBehaviour 
{
    // The route for the api that inserts data.
    [SerializeField] string apiURL = "http://localhost:5001/add";  
    [SerializeField] string apiURLedit = "http://localhost:5001/edit";



    //We need to start a coroutine that calls the request
    public IEnumerator uploadData()
    {
        // Unity sends a form, just as a html form. 
        WWWForm form = new WWWForm();

        // We need to create the form first, by manually adding fields. These fields match the names of the columns in the database.
        // The values from the other scripts is checked here and added to the form.
        form.AddField("Usuario", PlayerPrefs.GetString("Usuario", "Anonimo").ToString());
        form.AddField("Edad", PlayerPrefs.GetInt("Edad", 0).ToString()); 
        form.AddField("NV", PlayerPrefs.GetInt("NV", 0).ToString()); 
        form.AddField("NC", PlayerPrefs.GetInt("NC", 0).ToString()); 
        form.AddField("CPU", PlayerPrefs.GetInt("CPU", 0).ToString()); 
        form.AddField("RAM", PlayerPrefs.GetInt("RAM", 0).ToString()); 
        form.AddField("HDD", PlayerPrefs.GetInt("HDD", 0).ToString()); 
        Debug.Log(PlayerPrefs.GetString("Usuario","asfa"));
        Debug.Log(PlayerPrefs.GetInt("Edad",0));
        Debug.Log(form);

        // We create a request that makes a post to the url, and sends the form we just created.
        using (UnityWebRequest request = UnityWebRequest.Post(apiURL, form))
        {
            // The yield return line is the point at which execution will pause, and be resumed after the request ends.
            yield return request.SendWebRequest();

            // If there are no errors...
            //if (request.isNetworkError || request.isHttpError)
            //if(request.result == request.Result.ConnectionError || request.result == request.ProtocolError)
            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(request.error);
            }
            else
            {
                // We get the response text and log it in the console.
             
                Debug.Log(request.downloadHandler.text);
                Debug.Log("Form upload complete!");  }
        }
    }



// public IEnumerator Upload()
//     {
//         WWWForm form = new WWWForm();
//         form.AddField("Usuario", PlayerPrefs.GetString("Usuario", "Anonimo"));
//         form.AddField("Edad", PlayerPrefs.GetInt("Edad", 0)); 
//         form.AddField("NV", PlayerPrefs.GetInt("NV", 0)); 
//         form.AddField("NC", PlayerPrefs.GetInt("NC", 0)); 
//         form.AddField("CPU", PlayerPrefs.GetInt("CPU", 0)); 
//         form.AddField("RAM", PlayerPrefs.GetInt("RAM", 0)); 
//         form.AddField("HDD", PlayerPrefs.GetInt("HDD", 0)); 

//         using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:3000/add", form))
//         {
//             yield return www.SendWebRequest();

//             if (www.result != UnityWebRequest.Result.Success)
//             {
//                 Debug.Log(www.error);
//             }
//             else
//             {
//                 Debug.Log("Form upload complete!");
//             }
//         }
//     }




    public IEnumerator updateData()
    {
        // Unity sends a form, just as a html form. 
        WWWForm formupdate = new WWWForm();

        // We need to create the form first, by manually adding fields. These fields match the names of the columns in the database.
        // The values from the other scripts is checked here and added to the form.
        formupdate.AddField("Usuario", PlayerPrefs.GetString("Usuario", "Anonimo"));
        formupdate.AddField("NV", PlayerPrefs.GetInt("NV", 0)); 
        formupdate.AddField("NC", PlayerPrefs.GetInt("NC", 0)); 
        formupdate.AddField("CPU", PlayerPrefs.GetInt("CPU", 0)); 
        formupdate.AddField("RAM", PlayerPrefs.GetInt("RAM", 0)); 
        formupdate.AddField("HDD", PlayerPrefs.GetInt("HDD", 0)); 

        Debug.Log(formupdate);

        // We create a request that makes a post to the url, and sends the form we just created.
        using (UnityWebRequest request = UnityWebRequest.Post(apiURLedit, formupdate))
        {
            // The yield return line is the point at which execution will pause, and be resumed after the request ends.
            yield return request.SendWebRequest();

            // If there are no errors...
            //if(request.result == request.Result.ConnectionError || request.result == request.ProtocolError)
            //if (request.isNetworkError || request.isHttpError)
            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(request.error);
            }
            
            else
            {
                // We get the response text and log it in the console.
                Debug.Log(request.downloadHandler.text);
                Debug.Log("Form upload complete!");
            }
        }
    }
}