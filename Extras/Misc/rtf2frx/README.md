# Converter of RTF documents to FastReport.NET templates (FRX files)

Following console command will show a file selection dialog and will open converted file in FastReport designer:
```
  ./rtf2frx.exe
```

Following console command will convert a file __somedoc.rtf__ and will create new file __somedoc.rtf.frx__:
```
  ./rtf2frx.exe somedoc.rtf
```
You can also do a batch conversion. Just set first parameter which points to a folder with documents. 
Program will recursive traversal through directories and convert each found RTF file to FRX report template.
```
  ./rtf2frx.exe mydocumnets
```

Following console command will convert a file __somedoc.rtf__ and will create new file __newname.frx__:
```
  ./rtf2frx.exe somedoc.rtf newname.frx
```

Please note that the conversion is alpha quality. Any comments and tests appreciated.