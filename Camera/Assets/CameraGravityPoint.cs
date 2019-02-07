using System.Collections.Generic;
using UnityEngine;

public class CameraGravityPoint : MonoBehaviour
{
    // Value types
    [SerializeField] private int mass;

    // Reference types
    private static List<Vector3> gravityPointsList = new List<Vector3>();

    private void OnEnable()
    {
        RegisterPoint();
        UpdateCenterOfGravity();
    }

    private void OnDisable()
    {
        UnregisterPoint();
        UpdateCenterOfGravity();
    }

    // Use this for initialization
    void Start()
    {
	}
	
	// Update is called once per frame
	void Update()
    {
	}

    private void UpdateCenterOfGravity()
    {
    }

    private void RegisterPoint()
    {
    }

    private void UnregisterPoint()
    {
    }

    public void SetData(string data)
    {
        if (!int.TryParse(data, out mass))
            Debug.LogError("Could not parse data from LevelData!");
    }

    public string GetData()
    {
        return "";
    }

    public static bool HasCenterOfGravity
    {
        get
        {
            return gravityPointsList.Count > 0;
        }
    }

    public static Vector3 CenterOfGravity
    {
        get;
        private set;
    }
}
