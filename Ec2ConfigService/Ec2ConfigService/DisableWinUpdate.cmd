
@SET UPDATES TO DISABLED 
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update" /v AUOptions /t REG_DWORD /d 1 /f

@REM Restart the update service to stop any inflight downloads
@REM User "net start" and "stop" b/c they are synchronous
net stop wuauserv
net start wuauserv