Cordova MoreApps plugin
====================
# Overview #
Open more apps url.

[wp8] [phonegap build service]

This is open source cordova plugin.

You can see Plugins For Cordova in one page: http://cranberrygame.github.io?referrer=github

# Change log #
```c
```
# Install plugin #

## Cordova cli ##
https://cordova.apache.org/docs/en/edge/guide_cli_index.md.html#The%20Command-Line%20Interface - npm install -g cordova@5.0.0
```c
cordova plugin add cordova-plugin-share-moreapps
(when build error, use github url: cordova plugin add cordova plugin add https://github.com/cranberrygame/cordova-plugin-share-moreapps)
```

## Phonegap build service (config.xml) ##
https://build.phonegap.com/ - Apps - [specific project] - Update code - Zip file including config.xml
```c
<gap:plugin name="cordova-plugin-share-moreapps" source="npm" />
```

## Construct2 ##
Download construct2 plugin<br>
https://dl.dropboxusercontent.com/u/186681453/pluginsforcordova/index.html<br>
How to install c2 native plugins in xdk, cocoon and cordova cli<br>
https://plus.google.com/102658703990850475314/posts/XS5jjEApJYV

# Server setting #
```c
```

# API #
```javascript
//html5 website
//var moreAppsUrl = "http://cranberrygame.com/";
//android
//var moreAppsUrl = "market://search?q=pub:cranberrygame";
//blackberry10
//var moreAppsUrl = "http://appworld.blackberry.com/webstore/vendor/38078";
//ios
//var moreAppsUrl = "https://itunes.apple.com/artist/id693048135";
//windows8
//var moreAppsUrl = "http://windows.microsoft.com/en-us/windows/search#q=cranberry&s=Store";
//wp8
var moreAppsUrl = "zune:search?publisher=cranberry";

document.addEventListener("deviceready", function(){
}, false);

window.moreapps.openMoreAppsUrl(moreAppsUrl);
```
# Examples #
<a href="https://github.com/cranberrygame/cordova-plugin-share-moreapps/blob/master/example/basic/index.html">example/basic/index.html</a><br>

# Test #

# Useful links #

Cordova Plugins<br>
http://cranberrygame.github.io?referrer=github

# Credits #
