FastReport BG Objects.
-------------------------------------------

How to compile:
---------------

- open the .sln file;
- fix the "FastReport.dll" reference. By default, this dll is located in the
"C:\Program Files\FastReports\FastReport.Net Demo" folder;
- fix the "Fastreport.BG.dll" reference. By default, this dll is located in the
"C:\Program Files\FastReports\FastReport.BG Demo" folder;
- check that "Fastreport.BG.dll" reference is correct; if Visual Studio complains about it, fix it (you could find "Fastreport.BG.dll" in restored package);

How to register this dll in FastReport:
---------------------------------------

You can do it in several ways:

1) register using the FastReport IDE
- open the report designer;
- go "View|Options..." menu;
- on the "Plugins" tab, add the Fastreport.BGObjects.dll;
- restart FastReport.Net If you are working in the Visual Studio IDE, restart 
it as well;

2) edit manually the FastReport.config file
- by default, this file is located in the "C:\Documents and Settings\user_name\
Local Settings\Application Data\FastReport" folder;
- close any running instances of FastReport.Net;
- open the config file in any text editor and modify it in the following way:
  <?xml version="1.0" encoding="utf-8"?>
  <Config>
    ...
    <Plugins>
      <Plugin Name="c:\.....\FastReportBGObjects.dll"/>
    </Plugins>
  </Config>

3) register the dll programmatically
- add the "FastReportBGObjects.dll" reference to your project;
- execute the following code once at the application start:
RegisteredObjects.Add(typeof(SunburstObject), "ReportPage", 125);

In any case you have to place FastReportBGObjects.dll in the same folder with you application!


How to use it:
--------------

- now you should be able to create BG Chart objects in the Designer; you can find it on the bottom of the Toolbox.
