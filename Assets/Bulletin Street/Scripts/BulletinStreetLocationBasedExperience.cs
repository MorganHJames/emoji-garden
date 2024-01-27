using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Niantic.Lightship.AR.LocationAR;
using UnityEngine;
using Niantic.Lightship.AR.Samples;
using UnityEngine.InputSystem.XR;
using Unity.XR.CoreUtils;

public class BulletinStreetLocationBasedExperience : MonoBehaviour, ILocationBasedExperience
{
    public void PauseDueToLocalizationLost()
    {
        throw new NotImplementedException();
    }

    public void StartExperience(ILocationBasedExperience.LocationArgs data, LocationBasedExperienceController controller)
    {
        throw new NotImplementedException();
    }

    public void UnpauseDueToLocalizationRegained()
    {
        throw new NotImplementedException();
    }
}
