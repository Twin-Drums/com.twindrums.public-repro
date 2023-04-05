using System.Diagnostics;
using MongoDB.Driver;
using UnityEngine;

public class StartMongoDB : MonoBehaviour
{
    public MongoClient Client { get; private set; }

    private void Awake() => Connect();    
    
    private void Connect()
    {
        var stopwatch = Stopwatch.StartNew();
        UnityEngine.Debug.Log("[MongoDBClientService::Connect] Connecting to database ...");
        Client = new MongoClient(string.Format(MongoDBConstants.ConnectionString, MongoDBConstants.MongoDBUserName, MongoDBConstants.MongoDBPassword));
        UnityEngine.Debug.Log($"[MongoDBClientService::Connect] Connected to database ({stopwatch.Elapsed.TotalMilliseconds}ms)");        
    }
}