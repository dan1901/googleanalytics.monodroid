using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Google.Analytics.Tracking.Android;

namespace GoogleAnalytics.MonoDroid
{
    public abstract class TrackableActivity : Activity
    {

        protected override void OnStart()
        {
            base.OnStart();
            EasyTracker.Instance.ActivityStart(this);
        }

        protected override void OnStop()
        {
            base.OnStop();
            EasyTracker.Instance.ActivityStop(this);
        }
    }
}