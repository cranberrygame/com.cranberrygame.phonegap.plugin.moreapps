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

        public void openMoreAppsUrl(string args)
        {
			Debug.WriteLine("test");
  
			//JsonHelper.Deserialize<string[]>(args)[0];

			string moreAppsUrl=JsonHelper.Deserialize<string[]>(args)[0];
				
			//http://stackoverflow.com/questions/20445226/how-to-open-the-list-of-apps-from-the-same-publisher-on-the-marketplace
			//Search for an application, which is the default content type.
			MarketplaceSearchTask marketplaceSearchTask = new MarketplaceSearchTask();
			marketplaceSearchTask.SearchTerms = moreAppsUrl; //"\"RT Apps\"";
			marketplaceSearchTask.Show();
				
			DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "ok"));			
        }        

	}
}