using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class UnistiGumb : MonoBehaviour,
ITrackableEventHandler
{
    #region PRIVATE_MEMBER_VARIABLES

    private TrackableBehaviour mTrackableBehaviour;

    #endregion // PRIVATE_MEMBER_VARIABLES


    #region UNTIY_MONOBEHAVIOUR_METHODS

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    #endregion // UNTIY_MONOBEHAVIOUR_METHODS


    #region PUBLIC_METHODS
    public GameObject show;
    public GameObject hide;
    /// <summary>
    /// Implementation of the ITrackableEventHandler function called when the
    /// tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
        else
        {
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS


    #region PRIVATE_METHODS

    private void OnTrackingFound()
    {
        show.SetActive(true);

        // enabled all children
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }

        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
    }

    private void OnTrackingLost()
    {
        hide.SetActive(true);

        // disable all children
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
    }

    #endregion // PRIVATE_METHODS
}
