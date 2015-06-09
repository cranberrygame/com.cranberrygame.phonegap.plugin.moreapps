
module.exports = {
	openMoreAppsUrl : function (moreAppsUrl) {
		//Cordova.exec(null,null,"MoreApps","openMoreAppsUrl",[""]);//success,fail,class,method,params
		Cordova.exec(null,null,"MoreApps","openMoreAppsUrl",[moreAppsUrl]);//success,fail,class,method,params
		//alert("test");
	}
};
