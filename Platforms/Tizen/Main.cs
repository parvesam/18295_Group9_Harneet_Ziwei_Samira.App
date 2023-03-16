using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace _18295_Group9_Harneet_Ziwei_Samira;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
