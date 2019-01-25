# DotNetHighcharts
This is a branch of the source code from dotnethighcharts.codeplex.com - last updated May 23, 2014. 
Initial changes in this branch are implementation of Highchart Heatmaps, and i've updated the UI to use Bootstrap rather than JqueryUI. 
More recent updates included adding .NET controller content below the examples.

## Samples ASP.NET MVC project
Using Visual Studio, launch DotNet.Highcharts.Samples for a working example of each of the Highcharts supported in this library.

This project uses .NET Framework 4.5 and NUGET to provide AspNetMvc 4.0.2 ... I have not updated this project for several years as Highcharts began working on their own .NET SDK which was incompatible with this solution.

The Demo page (DemoController.cs) provides various charts of the following types:
Line Charts, Area Charts, Column and Bar Charts, Pie Charts, Scatter and Bubble Charts, Dynamic Charts, Combination Charts, 3D Charts, Guages and "More Chart Types" which demos my own implementation of the HeatMap as well as Poloar, Box Plot, Waterfall, Funnel and Speederweb.

The How To's page (HowTosController.cs)provides examples of charts and how the MVC Controller is used to customize via configuration.
These examples show additions of interaction, Effects, .NET Globalization, custom themes, events, data binding, and more.

## Summary of how it works
See the original source from dotnethighcharts.codeplex.com if you want to see the original project. 
But in brief, the Dotnet.Higcharts.Highcharts class implements IHtmlString and is used as the ViewModel for the Views.
This viewmodel is JsonSerialized to map to the Highcharts JS Libraries (version 4.0.1 included in the /Scripts folder).
The strength of using this .NET library is that you can use strongly typed objects rather than JS to set-up your Highcharts properties.

If I were to do this with more modern technologies, i'd consider TypeScript. 

My only true contributions to this DotNet project was to implement a Heatmap class and supporting code. 
I followed the project structure and naming conventions to the best of my ability.

I hope you find this example of interest.
