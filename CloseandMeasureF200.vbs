Public Function sleep(lSeconds)
'  Dim starttime, exittime, x
'  x = 0
'  starttime = timer
' exittime = starttime + lSeconds
'  do while timer < exittime
'    x = x +1
'  loop
	Dim time
	time = lSeconds * 1000
  WScript.Sleep time
End Function

Dim OMagellan, oRdrOle, OInstrument, OWorkspaceOle
'create Magellan COM object
Set oMagellan = CreateObject("Magellan2.Application")
'create readerserver via Magellan
Set oRdrOle   = oMagellan.CreateRdrOleObject
' configure instrument
oRdrOle.InstrumentName = "Infinite Series"
oRdrOle.DemoModeAllowed = True
oRdrOle.CommType = 1
oRdrOle.PortNr = 0
' create and set instrument object
Set oInstrument = oRdrOle.CreateInstrumentObject
oMagellan.InstrumentObject = oInstrument

'Set fso = CreateObject ("Scripting.FileSystemObject")
'Set stdout = fso.GetStandardStream (1)
'stdout.WriteLine oInstrument.InstrumentName

'create workspace object
Set oWorkspace = oMagellan.CreateWorkspaceObject
'Close Instrument
'OInstrument.MinTimeToShowWaitDlg = 0
OInstrument.PlateInOut = "In"
'configure workspace and insert method
oWorkspace.Empty = True
oWorkspace.InsertMethod("DSM_Robot203_Tecan")
oWorkspace.FileName = oWorkspace.NextDefaultFileName
'perform run
oWorkspace.StartRun
While oWorkspace.Status = 0 
   sleep(1)
Wend  
'store workspace
sleep(5)
Dim result
'result = oWorkspace.DoSerialization(True)
sleep(5)
'display results
'oMagellan.EvaluateResults(oWorkspace.FileName)
result = oWorkspace.AutomatedDataHandling()
sleep(5)
oWorkspace.AutomatedDataHandling()
sleep(5)


