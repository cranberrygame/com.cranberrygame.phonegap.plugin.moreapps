//Copyright (c) 2014 Sang Ki Kwon (Cranberrygame)
//Email: cranberrygame@yahoo.com
//Homepage: http://www.github.com/cranberrygame
//License: MIT (http://opensource.org/licenses/MIT)
using System;
using System.Windows;
using System.Runtime.Serialization;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
using Microsoft.Phone.Tasks;//MarketplaceDetailTask,MarketplaceReviewTask

using System.Diagnostics; //Debug.WriteLine

namespace Cordova.Extension.Commands
{
    public class MoreApps : BaseCommand
    {

        public async void openMoreAppsUrl(string args)
        {
			Debug.WriteLine("test");
  
			//JsonHelper.Deserialize<string[]>(args)[0];

			string moreAppsUrl=JsonHelper.Deserialize<string[]>(args)[0];

			//http://msdn.microsoft.com/en-us/library/windows/apps/jj662937(v=vs.105).aspx
			//http://jacobkurien.wordpress.com/2013/06/30/other-apps-by-the-same-publisher-for-windows-phone-8/
			await Windows.System.Launcher.LaunchUriAsync(new Uri(moreAppsUrl));	
			
			DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "ok"));			
        }        

	}
}