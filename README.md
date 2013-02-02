googleanalytics.monodroid
=========================

A monodroid binding for the Google Analytics API.

Installation
-----
Follow these steps to use the Google Analytics SDK in your Mono for Android app.

1. Add a reference to the GoogleAnalytics.Monodroid Assembly
2. Update your manifest with the INTERNET and ACCESS\_NETWORK\_STATE permissions

After performing the previous two steps you need to add a new resource file to the app with the following contents:

    <resources xmlns:tools="https://schemas.android.com/tools" tools:ignore="TypographyDashes">
        <bool name="ga_reportUncaughtExceptions>true</bool>
        <string name="ga_trackingId">UA-XXXX-Y</string>
	    <string name="ga_autoActivityTracking">true</string>
    </resources>

The ga_trackingId can be obtained by registering a new tracking profile at: [http://support.google.com/analytics/bin/answer.py?hl=en&answer=2614741](http://support.google.com/analytics/bin/answer.py?hl=en&answer=2614741)

Name the resource file analytics.xml and make sure that the build action for the file is set to AndroidResource!

Usage
-----
To use the tracking logic, you need to add two pieces of code in your activity

    public class MyActivity: Activity
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

For convenience there's a base type `TrackableActivity` included in the assembly. The use of this base type is not required.

All analytics calls from within an activity are tracked. If you have to make calls from other components, you may have to use `EasyTracker.Instance.Context = <myActivityInstance>`

More information
----------------
This readme file covers the basics. There's a lot more you can do. Check out the following sources for more information:

- [https://developers.google.com/analytics/devguides/collection/android/v2/advanced](https://developers.google.com/analytics/devguides/collection/android/v2/advanced "Advanced configuration")
- [https://developers.google.com/analytics/devguides/collection/android/v2/events](https://developers.google.com/analytics/devguides/collection/android/v2/events "Measure event activity in the app")
- [https://developers.google.com/analytics/devguides/collection/android/v2/usertimings](https://developers.google.com/analytics/devguides/collection/android/v2/usertimings "Measure user timings in the app")