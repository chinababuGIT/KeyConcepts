@REM This script is called during the last phase of the Sysprep
@REM Specialize operation.  Please see the Sysprep2008.XML file
@REM for closer inspection on the order which this synchronous
@REM command is run.


@REM ***************
@REM Re-enable RDP connections.  By default, this script will
@REM only be called after our prior embedded synchronous 
@REM commands have already scrambled the Administrator password
@REM and then re-enabled the account.  

reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server" /v fDenyTSConnections /t REG_DWORD /d 0 /f